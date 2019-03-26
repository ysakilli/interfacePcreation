using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Creation
{
    class Configuration
    {
        public Configuration()
        {

        }
       /* public static bool PictureFix (Bitmap picture)
        {
            if (picture.Width >picture.Height)
            {
                picture.Height{ get} = picture.Width.Equals;

                return a;
            }
            else if (a < b)
            {
                b = a;
                return b;
            }
            else
            {

                return(1);

            }

           
            
            
        } */
        public static bool ConvertLightColor(Bitmap b) // Allow Color Change 
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);

                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    int red = (byte)(.255 * r1 + .0 * g1 + .0 * b1);
                    int green = (byte)(.0 * r1 + .255 * g1 + .0 * b1);
                    int blue = (byte)(.0 * r1 + .255 * g1 + .0 * b1);
                    int white = (byte)(.255 * r1 + .255 * g1 + .255 * b1);
                    int black = (byte)(.0 * r1 + .0 * g1 + .0 * b1);

                    
                    if ( ( (r1 < 200) && (g1 >= 200) && (b1 < 200) ) || ( ( r1 >= 200 ) &&( g1 >= 150 ) &&(b1 <=50 )) || ((r1 > 155) && ( g1 > 117) && (b1==0) && (g1 < 220 ) ) || ((r1 == 0) && (g1 >= 200) && (b1 == 0 )))  
                    {
                        
                        g1 = green;
                       
                        b.SetPixel(i, j, Color.FromArgb(0 , 255, 0));    //Amber Or green

                    }
                    else if ( ( (r1 >= 90) && (g1 < 200) && (b1 >= 200) ) || ( (r1>=90) && (b1 >= 150) &&  (g1 <50) ) || ((r1<=55) && (b1>=250) && (g1<180)) || (( r1 == 0 ) && ( g1 == 0 ) && ( b1 >=200) ) || (((r1 <= 130) && (g1 >= 45) && (b1 >= 90)) && ( (b1 <=239) && (g1 <= 180)) ) || (( r1<= 60) && (g1 >= 100) && (g1 <= 200) && (b1 >= 170) ))
                    {
                        
                        b1 = blue;
                        b.SetPixel(i, j, Color.FromArgb(0, 0, 255));  // Blue Settings

                    }
                    else if ((r1 >= 200) && (g1 < 200) && (b1 < 200) || ((r1 >= 200) && (g1 == 0) && (b1 == 0)))
                    {

                        r1 = red;

                        b.SetPixel(i, j, Color.FromArgb(255, 0, 0));    // Red settings

                    }
                    else if ( ((r1 >= 200) && (g1 >= 200) && (b1 >= 200)) || ((g1>=220) && ( b1 >=220))  )
                    {

                        r1 = white;
                        g1 = white;
                        b1 = white;
                        b.SetPixel(i, j, Color.FromArgb(255, 255, 255));            //White Settings

                    }
                    else if ((r1 <= 200) && (g1 <= 200) && (b1 <= 200))
                    {

                        r1 = black;
                        g1 = black;
                        b1 = black;
                        b.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        //Black Settings

                    }

                }
            }
            return (true);

        }
        public static bool ConvertDarkColor(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);

                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    int red = (byte)(.255 * r1 + .0 * g1 + .0 * b1);
                    int green = (byte)(.0 * r1 + .255 * g1 + .0 * b1);
                    int blue = (byte)(.0 * r1 + .255 * g1 + .0 * b1);
                    int white = (byte)(.255 * r1 + .255 * g1 + .255 * b1);
                    int black = (byte)(.0 * r1 + .0 * g1 + .0 * b1);







                    if (((r1 < 200) && (g1 >= 200) && (b1 < 200)) || ((r1 >= 200) && (g1 >= 150) && (b1 <= 50)) || ((r1 > 155) && (g1 > 117) && (b1 == 0) && (g1 < 220)) || ((r1 == 0) && (g1 >= 200) && (b1 == 0)))
                    {

                        g1 = green;

                        b.SetPixel(i, j, Color.FromArgb(0, 128, 0));    //Amber Or green

                    }
                    else if (((r1 >= 90) && (g1 < 200) && (b1 >= 200)) || ((r1 >= 90) && (b1 >= 150) && (g1 < 50)) || ((r1 <= 55) && (b1 >= 250) && (g1 < 180)) || ((r1 == 0) && (g1 == 0) && (b1 >= 200)) || (((r1 <= 130) && (g1 >= 45) && (b1 >= 90)) && ((b1 <= 239) && (g1 <= 180))) || ((r1 <= 60) && (g1 >= 100) && (g1 <= 200) && (b1 >= 170)))
                    {

                        b1 = blue;
                        b.SetPixel(i, j, Color.FromArgb(0, 0, 128));  // Blue Settings

                    }
                    else if ((r1 >= 200) && (g1 < 200) && (b1 < 200) || ((r1 >= 200) && (g1 == 0) && (b1 == 0)))
                    {

                        r1 = red;

                        b.SetPixel(i, j, Color.FromArgb(128, 0, 0));    // Red settings

                    }
                    else if (((r1 >= 200) && (g1 >= 200) && (b1 >= 200)) || ((g1 >= 220) && (b1 >= 220)))
                    {

                        r1 = white;
                        g1 = white;
                        b1 = white;
                        b.SetPixel(i, j, Color.FromArgb(128, 128, 128));            //White Settings

                    }
                    else if ((r1 <= 200) && (g1 <= 200) && (b1 <= 200))
                    {

                        r1 = black;
                        g1 = black;
                        b1 = black;
                        b.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        //Black Settings

                    }

                }
               
            }
            return (true);

        }

    }
}
