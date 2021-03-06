﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CylinderGen
{
    public partial class Form1 : Form
    {
        public string launchpath = AppDomain.CurrentDomain.BaseDirectory;
        public string texture;
        public string texturefile = "example";
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image Files (*.bmp, *.png)|*.bmp;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Select an Image";
            openFileDialog1.InitialDirectory = launchpath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Path.Combine(launchpath + "\\Output\\Cylinders\\")))
                {
                    Directory.CreateDirectory(Path.Combine(launchpath + "\\Output\\Cylinders\\"));
                }
            }
            catch
            {
                MessageBox.Show("Unable to Write To Output Directory");
            }
        }


        private static string MakeValidFileName(string name)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "_");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Preliminary Checks
            if(String.IsNullOrEmpty(MakeValidFileName(textBox1.Text)))
            {
                MessageBox.Show("Invalid or empty filename.");
                return;
            }
            if (topradius.Value == 0 || bottomradius.Value == 0)
            {
                MessageBox.Show("Both radii must be above zero.");
                return;
            }
            if (totalfaces.Value < 6)
            {
                MessageBox.Show("6 faces or greater are required");
                return;
            }
            if (string.IsNullOrEmpty(texture))
            {
                texture = launchpath + "\\Textures\\example.png";
            }
            if (texturewrap.Value == 0)
            {
                MessageBox.Show("The texture wrapping value must be above zero.");
                return;
            }
            string objectfile = Path.Combine(launchpath + "Output\\Cylinders\\" + MakeValidFileName(textBox1.Text));
            File.Delete(objectfile);
            //Arrays
            decimal[] bottomarray = new decimal[3];
            decimal[] toparray = new decimal[3];
            List<string> writeout = new List<string>();
            //Write Object Header
            writeout.Add(";Object created by OpenBVE Cylinder Generator 1.0");
            writeout.Add(";The output from this utility is public domain content");

            //Bools
            bool Xequals = false;
            bool Yequals = false;
            bool Zequals = false;

            //Load bottom points into array
            bottomarray[0] = bottomX.Value;
            bottomarray[1] = bottomY.Value;
            bottomarray[2] = bottomZ.Value;
            //Load top points into array
            toparray[0] = topX.Value;
            toparray[1] = topY.Value;
            toparray[2] = topZ.Value;

            //The points are loaded- Check if both are the same
            if (toparray.SequenceEqual(bottomarray))
            {
                MessageBox.Show("Both points are the same- Please change one.");
                return;
            }

            //At least one set of points needs to be in the same dimensions for this version
            if (bottomarray[0] == toparray[0])
            {
                Xequals = true;
            }
            if (bottomarray[1] == toparray[1])
            {
                Yequals = true;
            }
            if (bottomarray[2] == toparray[2])
            {
                Zequals = true;
            }

            string finalbottom = "";
            string finaltop = "";
            writeout.Add("[MeshBuilder]");
            //Now generate the appropriate points
            var items = (double)totalfaces.Value;
            for (var i = 0; i < items; i++)
            {
                double TopVertexoutX;
                double TopVertexoutY;
                double TopVertexoutZ;
                double BottomVertexoutX;
                double BottomVertexoutY;
                double BottomVertexoutZ;
                double TopNormalX = 0;
                double TopNormalY = 0;
                double TopNormalZ = 0;
                double BottomNormalX = 0;
                double BottomNormalY = 0;
                double BottomNormalZ = 0;

                if (Xequals == false)
                {
                     //Points move along the X-Axis
                     TopVertexoutX = (double)toparray[0];
                     TopVertexoutY = (double)toparray[1] + (double)topradius.Value * Math.Cos(2 * Math.PI * i / items);
                     TopVertexoutZ = (double)toparray[2] +(double)topradius.Value * Math.Sin(2 * Math.PI * i / items);

                     BottomVertexoutX = (double)bottomarray[0];
                     BottomVertexoutY = (double)bottomarray[1] +(double)bottomradius.Value * Math.Cos(2 * Math.PI * i / items);
                     BottomVertexoutZ = (double)bottomarray[2] + (double)bottomradius.Value * Math.Sin(2 * Math.PI * i / items);
                     if (normalsyes.Checked == true)
                     {
                         TopNormalX = 0;
                         TopNormalY = (double)toparray[1] + (double)(topradius.Value +1) * Math.Cos(2 * Math.PI * i / items);
                         TopNormalZ = (double)toparray[2] + (double)(topradius.Value +1) * Math.Sin(2 * Math.PI * i / items);

                         BottomNormalX = 0;
                         BottomNormalY = (double)bottomarray[1] + (double)(bottomradius.Value +1) * Math.Cos(2 * Math.PI * i / items);
                         BottomNormalZ = (double)bottomarray[2] + (double)(bottomradius.Value +1) * Math.Sin(2 * Math.PI * i / items);
                     }
                }
                else if(Yequals == false && (Math.Abs(toparray[1] - bottomarray[1]) > Math.Abs(toparray[2] - bottomarray[2])))
                {
                    //Points move along the Y-Axis
                    TopVertexoutX = (double)toparray[0] + (double)topradius.Value * Math.Cos(2 * Math.PI * i / items);
                    TopVertexoutY = (double)toparray[1];
                    TopVertexoutZ = (double)toparray[2] + (double)topradius.Value * Math.Sin(2 * Math.PI * i / items);

                    BottomVertexoutX = (double)bottomarray[0] + (double)bottomradius.Value * Math.Cos(2 * Math.PI * i / items);
                    BottomVertexoutY = (double)bottomarray[1];
                    BottomVertexoutZ = (double)bottomarray[2] + (double)bottomradius.Value * Math.Sin(2 * Math.PI * i / items);
                    if (normalsyes.Checked == true)
                    {
                        TopNormalX = (double)toparray[0] + (double)(topradius.Value +1) * Math.Cos(2 * Math.PI * i / items);
                        TopNormalY = 0;
                        TopNormalZ = (double)toparray[2] + (double)(topradius.Value +1) * Math.Sin(2 * Math.PI * i / items);

                        BottomNormalX = (double)bottomarray[0] + (double)(bottomradius.Value +1) * Math.Cos(2 * Math.PI * i / items);
                        BottomNormalY = 0;
                        BottomNormalZ = (double)bottomarray[2] + (double)(bottomradius.Value + 1) * Math.Sin(2 * Math.PI * i / items);
                    }

                }
                else
                {
                    //Points move along the Z-Axis
                    TopVertexoutX = (double)toparray[0] + (double)topradius.Value * Math.Cos(2 * Math.PI * i / items);
                    TopVertexoutY = (double)toparray[1] + (double)topradius.Value * Math.Sin(2 * Math.PI * i / items);
                    TopVertexoutZ = (double)toparray[2];

                    BottomVertexoutX = (double)bottomarray[0] + (double)bottomradius.Value * Math.Cos(2 * Math.PI * i / items);
                    BottomVertexoutY = (double)bottomarray[1] + (double)bottomradius.Value * Math.Sin(2 * Math.PI * i / items);
                    BottomVertexoutZ = (double)bottomarray[2];
                    if (normalsyes.Checked == true)
                    {
                        TopNormalX = (double)toparray[0] + (double)topradius.Value * Math.Cos(2 * Math.PI * i / items);
                        TopNormalY = (double)toparray[1] + (double)topradius.Value * Math.Sin(2 * Math.PI * i / items);
                        TopNormalZ = 0;

                        BottomNormalX = (double)bottomarray[0] + (double)(bottomradius.Value + 1) * Math.Cos(2 * Math.PI * i / items);
                        BottomNormalY = (double)bottomarray[1] + (double)(bottomradius.Value + 1) * Math.Sin(2 * Math.PI * i / items);
                        BottomNormalZ = 0;
                    }
                }


                string bottomvertex;
                string topvertex;
                //Now write out our completed vertex into the file
                if (normalsyes.Checked == true)
                {
                    bottomvertex = "Vertex " + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomVertexoutX))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomVertexoutY))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomVertexoutZ))).ToString()
                        + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomNormalX))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomNormalY))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomNormalZ))).ToString();
                    topvertex = "Vertex " + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopVertexoutX))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopVertexoutY))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopVertexoutZ))).ToString()
                        + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopNormalX))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopNormalY))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopNormalZ))).ToString();
                }
                else
                {
                    bottomvertex = "Vertex " + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomVertexoutX))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomVertexoutY))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(BottomVertexoutZ))).ToString();
                    topvertex = "Vertex " + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopVertexoutX))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopVertexoutY))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(TopVertexoutZ))).ToString();
                }
                writeout.Add(bottomvertex);
                writeout.Add(topvertex);
                //Handle the final face & the central points
                if (i == 0)
                {
                    finalbottom = bottomvertex;
                    finaltop = topvertex;
                }
                else if (i == (items - 1))
                {
                    writeout.Add(finalbottom);
                    writeout.Add(finaltop);
                    if (topface.Checked == true)
                    {
                        string central = "Vertex " + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(toparray[0]))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(toparray[1]))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(toparray[2]))).ToString();
                        writeout.Add(central);
                    }
                    else if (bottomface.Checked == true)
                    {
                        string central = "Vertex " + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(bottomarray[0]))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(bottomarray[1]))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(bottomarray[2]))).ToString();
                        writeout.Add(central);
                    }
                    else if (bothface.Checked == true)
                    {
                        string centraltop = "Vertex " + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(toparray[0]))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(toparray[1]))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(toparray[2]))).ToString() + ";ct";
                        string centralbottom = "Vertex " + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(bottomarray[0]))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(bottomarray[1]))).ToString() + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(bottomarray[2]))).ToString() + ";cb";
                        writeout.Add(centraltop);
                        writeout.Add(centralbottom);
                    }
                    
                }
            }
            //Face for each segment
            int[] face = new int[4];
            face[0] = 2;
            face[1] = 3;
            face[2] = 1;
            face[3] = 0;
            //Face for top cap
            int[] topfacearray = new int[3];
            topfacearray[0] = ((int)items * 2) + 2;
            topfacearray[1] = 1;
            topfacearray[2] = 3;
            //Face for bottom cap
            int[] bottomfacearray = new int[3];
            bottomfacearray[0] = ((int)items * 2) + 3;
            bottomfacearray[1] = 0;
            bottomfacearray[2] = 2;
            //Now generate the Faces statements
            for (var i = 0; i < items; i++)
            {
                string currentface;
                //Check if we need to reverse our face statements
                if (outside.Checked == true)
                {
                    //We're generating an outside face
                    //Check if the top X is greater than the bottom X- If so, reverse
                    //Check if the bottom Y is greater than the top Y- If so, reverse
                    bool reversed = false;
                    if (bottomarray[0] == toparray[0] && bottomarray[1] > toparray[1] && bottomarray[2] == toparray[2])
                    {
                        reversed = true;
                    }
                    if (toparray[0] > bottomarray[0] && bottomarray[1] == toparray[1] && bottomarray[2] == toparray[2])
                    {
                        reversed = true;
                    }
                    if(toparray[0] == bottomarray[0] && bottomarray[1] == toparray[1] && toparray[2] > bottomarray[2])
                    {
                        reversed = true;
                    }
                    if (toparray[0] > bottomarray[0] && toparray[1] > bottomarray[1] && toparray[2] == bottomarray[2])
                    {
                        reversed = true;
                    }
                    if (toparray[0] > bottomarray[0] && toparray[1] == bottomarray[1] && toparray[2] > bottomarray[2])
                    {
                        reversed = true;
                    }

                    if(reversed == true)
                    {
                        currentface = "Face " + Convert.ToString(face[0]) + "," + Convert.ToString(face[1]) + "," + Convert.ToString(face[2]) + "," + Convert.ToString(face[3]);
                        if (topface.Checked == true)
                        {
                            string topout = "Face " + Convert.ToString(topfacearray[0]) + "," + Convert.ToString(topfacearray[1]) + "," + Convert.ToString(topfacearray[2]);
                            writeout.Add(topout);
                        }
                        else if (bottomface.Checked == true)
                        {
                            string bottomout = "Face " + Convert.ToString(bottomfacearray[2]) + "," + Convert.ToString(bottomfacearray[1]) + "," + Convert.ToString(bottomfacearray[0]);
                            writeout.Add(bottomout);
                        }
                        else if (bothface.Checked == true)
                        {
                            string topout = "Face " + Convert.ToString(topfacearray[0]) + "," + Convert.ToString(topfacearray[1]) + "," + Convert.ToString(topfacearray[2]);
                            writeout.Add(topout);
                            string bottomout = "Face " + Convert.ToString(bottomfacearray[2]) + "," + Convert.ToString(bottomfacearray[1]) + "," + Convert.ToString(bottomfacearray[0]);
                            writeout.Add(bottomout);
                        }
                    }
                    else
                    {
                        currentface = "Face " + Convert.ToString(face[3]) + "," + Convert.ToString(face[2]) + "," + Convert.ToString(face[1]) + "," + Convert.ToString(face[0]);
                        if (topface.Checked == true)
                        {
                            string topout = "Face " + Convert.ToString(topfacearray[2]) + "," + Convert.ToString(topfacearray[1]) + "," + Convert.ToString(topfacearray[0]);
                            writeout.Add(topout);
                        }
                        else if (bottomface.Checked == true)
                        {
                            string bottomout = "Face " + Convert.ToString(bottomfacearray[0]) + "," + Convert.ToString(bottomfacearray[1]) + "," + Convert.ToString(bottomfacearray[2]);
                            writeout.Add(bottomout);
                        }
                        else if (bothface.Checked == true)
                        {
                            string topout = "Face " + Convert.ToString(topfacearray[2]) + "," + Convert.ToString(topfacearray[1]) + "," + Convert.ToString(topfacearray[0]);
                            writeout.Add(topout);
                            string bottomout = "Face " + Convert.ToString(bottomfacearray[0]) + "," + Convert.ToString(bottomfacearray[1]) + "," + Convert.ToString(bottomfacearray[2]);
                            writeout.Add(bottomout);
                        }
                    }

                }
                else if (both.Checked == true)
                {
                        currentface = "Face2 " + Convert.ToString(face[0]) + "," + Convert.ToString(face[1]) + "," + Convert.ToString(face[2]) + "," + Convert.ToString(face[3]);
                }
                else
                {
                    
                        currentface = "Face " + Convert.ToString(face[0]) + "," + Convert.ToString(face[1]) + "," + Convert.ToString(face[2]) + "," + Convert.ToString(face[3]);
                        if (topface.Checked == true)
                        {
                            string topout = "Face " + Convert.ToString(topfacearray[0]) + "," + Convert.ToString(topfacearray[1]) + "," + Convert.ToString(topfacearray[2]);
                            writeout.Add(topout);
                        }
                        else if (bottomface.Checked == true)
                        {
                            string bottomout = "Face " + Convert.ToString(bottomfacearray[2]) + "," + Convert.ToString(bottomfacearray[1]) + "," + Convert.ToString(bottomfacearray[0]);
                            writeout.Add(bottomout);
                        }
                        else if (bothface.Checked == true)
                        {
                            string topout = "Face " + Convert.ToString(topfacearray[0]) + "," + Convert.ToString(topfacearray[1]) + "," + Convert.ToString(topfacearray[2]);
                            writeout.Add(topout);
                            string bottomout = "Face " + Convert.ToString(bottomfacearray[2]) + "," + Convert.ToString(bottomfacearray[1]) + "," + Convert.ToString(bottomfacearray[0]);
                            writeout.Add(bottomout);
                        }

                }
                
                
                   
                writeout.Add(currentface);
                //Increment the faces
                face[0] += 2;
                face[1] += 2;
                face[2] += 2;
                face[3] += 2;
                topfacearray[1] += 2;
                topfacearray[2] += 2;
                bottomfacearray[1] += 2;
                bottomfacearray[2] += 2;
            }
            //Texture
            writeout.Add("");
            writeout.Add("[Texture]");
            writeout.Add("Load " + texturefile + ".png");
            //Calculate the texture split
            double textureinterval = ((double)texturewrap.Value / items);
            //Check whether we need to add co-ordinates for top/ bottom face
            int calculated;
            if (topface.Checked == true || bottomface.Checked == true)
            {
                calculated = 2;
            }
            else if (bothface.Checked == true)
            {
                calculated = 3;
            }
            else
            {
                calculated = 1;
            }
            int currentcoord = 0;
            for (var i = 0; i < (items + calculated); i++)
            {
                double textureinterval2 = textureinterval * i;
                                
                string currenttexure = "Coordinates "+ currentcoord + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(textureinterval2))).ToString() +",0";
                string currenttexure2 = "Coordinates " + (currentcoord + 1) + "," + Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(textureinterval2))).ToString() + ",1";
                writeout.Add(currenttexure);
                writeout.Add(currenttexure2);
                currentcoord += 2;
            }
            //Write out to our file
            if (writeout.Count > 0)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(objectfile, true))
                {
                    foreach (string item in writeout)
                    {
                        file.WriteLine(item);
                    }
                }
            }
            //Copy Across Texture
            ConvertAndMove(launchpath, texture, texturefile);
        }

        static void ConvertAndMove(string launchdir, string inputfile, string filename)
        {
            try
            {
                if (Path.GetExtension(inputfile) == ".bmp")
                {
                    
                        System.Drawing.Image image1 = System.Drawing.Image.FromFile(@inputfile);
                        image1.Save(@launchdir + "\\Output\\Cylinders\\" + filename + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    
                }
                else
                {
                        System.IO.File.Copy(inputfile, launchdir + "\\Output\\Cylinders\\" + filename + ".png", true);
                }
            }
            catch
            {
                //Show missing texture error
                MessageBox.Show("The texture:" + "\n" + inputfile + "\n" + "is missing or in an unsupported format!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                texture = openFileDialog1.FileName;
                texturefile = Path.GetFileNameWithoutExtension(texture);
            }
        }


    }
}
