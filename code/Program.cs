using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katana_Premiere_Edition
{
    public partial class program1 : Form
    {
        Bitmap off;
        Timer tt = new Timer();
        List<zero> lzero = new List<zero>();
        List<line> linel = new List<line>();
        List<back1> lback = new List<back1>();
        List<btile> lbtile = new List<btile>();
        List<btile2> l2btile = new List<btile2>();
        List<items> litems = new List<items>();
        List<transport> ltransport = new List<transport>();
        List<shuriken> lshuriken = new List<shuriken>();
        List<f16> lcraft = new List<f16>();
        List<rocket> lrocket = new List<rocket>();
        List<chest> lchest = new List<chest>();
        List<sword> lsword = new List<sword>();
        List<cyborg> lenemy = new List<cyborg>();
        List<elevator> lelevator = new List<elevator>();
        List<eBullet> lbullet = new List<eBullet>();
        List<junk> ljunk = new List<junk>();
        List<ladder> lladder = new List<ladder>();
        List<ship> lship = new List<ship>();
        List<spear> lspear = new List<spear>();
        bool move, fMove, climb2;
        public program1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += Program1_Paint;
            this.Load += Program1_Load;
            this.MouseMove += Program1_MouseMove;
            this.MouseDown += Program1_MouseDown;
            this.MouseUp += Program1_MouseUp;
            this.KeyDown += Program1_KeyDown;
            tt.Tick += Tt_Tick;
            tt.Start();
        }
        int b = 0;
        int ct = 0;
        bool state = true;
        bool fly = true;
        bool movealong, movealong2;

        public class back1
        {
            public int XD, YD;
            public Bitmap im;
            public int XS, YS;
        }
        public class zero
        {
            public int x, y;
            public List<Bitmap> lzero2 = new List<Bitmap>();
            public int icurr;
            public int form;
            public bool death;
            public bool lad;
        }
        public class btile
        {
            public int x, y;
            public Bitmap img;
        }
        public class line
        {
            public int x, y, x2, y2;
        }

        public class btile2
        {
            public int x, y;
            public Bitmap img;
        }
        public class items
        {
            public int x, y;
            public Bitmap img;
        }
        public class transport
        {
            public int x, y;
            public Bitmap img;
            public int dir;
        }
        public class shuriken
        {
            public int x, y;
            public Bitmap img;
        }
        public class f16
        {
            public int x, y;
            public Bitmap img;
        }
        public class rocket
        {
            public int x, y;
            public Bitmap img;
        }
        public class cyborg
        {
            public int x, y;
            public List<Bitmap> lcyborg = new List<Bitmap>();
            public int icurr;
            public int death;
            public bool shoot;
        }
        public class sword
        {
            public int x, y;
            public Bitmap img;
        }
        public class chest
        {
            public int x, y;
            public List<Bitmap> lchests = new List<Bitmap>();
            public int icurr;
        }
        public class elevator
        {
            public int x, y;
            public Bitmap img;
            public int dir;
        }
        public class eBullet
        {
            public int x, y;
            public int dir;
            public Bitmap img;
        }
        public class junk
        {
            public int x, y;
            public List<Bitmap> ljunks = new List<Bitmap>();
            public int dir = 0;
            public int icurr;
            public bool death;
        }
        public class ladder
        {
            public int x, y;
            public Bitmap img;
        }
        public class spear
        {
            public int x, y;
            public Bitmap img;
        }
        public class ship
        {
            public int x, y;
            public Bitmap img;
        }

        private void Program1_KeyDown(object sender, KeyEventArgs e)
        {
            /* lback[0].XS += 2;*/ //MOVEMENT OF BACKGROUND
            if (e.KeyCode == Keys.R/* && lsword.Count != 0*/)
            {
                lzero[0].icurr = 20;
                lzero[0].form = 1;
            }
            if (e.KeyCode == Keys.A)
            {
                lzero[0].x -= 10;

                if (lzero[0].form == 0)
                {
                    if (lzero[0].icurr >= 18 || lzero[0].icurr < 10)
                    {
                        lzero[0].icurr = 10;
                    }
                }
                else if (lzero[0].form == 1)
                {
                    if (lzero[0].icurr >= 23 || lzero[0].icurr < 20)
                    {
                        lzero[0].icurr = 20;
                    }
                }
                lzero[0].icurr++;
            }
            if (e.KeyCode == Keys.D)
            {
                lzero[0].x += 10;
                if (lzero[0].form == 0)
                {
                    if (lzero[0].icurr >= 18 || lzero[0].icurr < 10)
                    {
                        lzero[0].icurr = 10;
                    }
                }
                else if (lzero[0].form == 1)
                {
                    if (lzero[0].icurr >= 23 || lzero[0].icurr < 20)
                    {
                        lzero[0].icurr = 20;
                    }
                }
                lzero[0].icurr++;
            }
            if (e.KeyCode == Keys.W)
            {
                if (lzero[0].x >= lladder[0].x && lzero[0].x + 100 < lladder[0].x + 150)
                {
                    if (lzero[0].y >= 100)
                    {
                        climb2 = true;
                        lzero[0].y -= 10;
                        climb();
                    }
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (lzero[0].x >= lladder[0].x && lzero[0].x + 100 < lladder[0].x + 150)
                {
                    if (lzero[0].y < 460)
                    {
                        climb2 = true;
                        lzero[0].y += 10;
                        climb();
                    }
                }
            }
            if (e.KeyCode == Keys.W && fly == false && climb2 == false)
            {
                lzero[0].y -= 150;
            }
            if (e.KeyCode == Keys.F)
            {
                spear2();
            }
        }


        bool bull;
        bool chesto;
        int k;
        private void Program1_MouseDown(object sender, MouseEventArgs e)
        {
            //lback[0].XS += 2; //MOVEMENT OF BACKGROUND
            if (e.Button == MouseButtons.Left && lzero[0].form == 1)
            {
                if (e.X >= lzero[0].x && e.X <= lzero[0].x + 100)
                {
                    if (e.Y >= lzero[0].y && e.Y <= lzero[0].y + 100)
                    {
                        oldx = e.X;
                        oldy = e.Y;
                        mainx = oldx;
                        mainy = oldy;
                        move = true;
                        line pnn = new line();
                        pnn.x = oldx;
                        pnn.y = oldy;
                        pnn.x2 = oldx;
                        pnn.y2 = oldy;
                        linel.Add(pnn);
                    }
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                if (lzero[0].form == 0)
                {
                    bull = true;
                    lzero[0].icurr = 34;
                    frame = true;
                }
                if (lzero[0].form == 1)
                {
                    lzero[0].icurr = 24;
                    for (int i = 0; i < lenemy.Count; i++)
                    {
                        if (lenemy[i].x <= lzero[0].x + 100 && lzero[0].x + 100 <= lenemy[i].x + 60)
                        {
                            if (lzero[0].y + 100 >= lenemy[i].y + 70)
                            {
                                lenemy[i].icurr = 4;
                                lenemy[i].death = 1;
                            }
                        }
                    }
                    for (int i = 0; i < ljunk.Count; i++)
                    {
                        if (ljunk[i].x <= lzero[0].x + 100 && lzero[0].x + 100 <= ljunk[i].x + 60)
                        {
                            if (lzero[0].y + 100 >= ljunk[i].y + 70)
                            {
                                ljunk[i].death = true;
                            }
                        }
                    }
                }
                if (lchest.Count != 0)
                {
                    if (lzero[0].x + 100 >= lchest[0].x) //weselt 3and el chest
                    {
                        chesto = true;
                    }
                }
            }
        }
        int oldx, oldy, dx, dy, dx2, dy2, mainx, mainy;
        private void Program1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                /* lback[0].XS += 2;*/ //MOVEMENT OF BACKGROUND
                dx = e.X - oldx;
                dy = e.Y - oldy;
                dx2 += dx;
                dy2 += dy;
                oldx = e.X;
                oldy = e.Y;
                linel[0].x += dx;
                linel[0].y += dy;
                //DrawDubb(CreateGraphics());

            }
        }
        private void Program1_MouseUp(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                /* lback[0].XS += 2;*/ //MOVEMENT OF BACKGROUND
                linel.RemoveAt(0);

                lzero[0].x += dx2;
                lzero[0].y += dy2;
                dx2 = 0; dy2 = 0;
                lzero[0].icurr = 24;
                //DrawDubb(CreateGraphics());
                move = false;
                //int xa = lenemy.Count();MessageBox.Show( lenemy.Count+"  ");
                for (int i = 0; i < lenemy.Count; i++)
                {
                    if (lenemy[i].x <= e.X && lenemy[i].x >= mainx)
                    {
                        if (lzero[0].y + 100 >= lenemy[i].y && lzero[0].y - 10 < lenemy[i].y)
                        {
                            lenemy[i].icurr = 4;
                            lenemy[i].death = 1;
                        }
                    }
                }
                for (int i = 0; i < ljunk.Count; i++)
                {
                    if (ljunk[i].x <= e.X && ljunk[i].x >= mainx)
                    {
                        if (lzero[0].y + 100 >= ljunk[i].y && lzero[0].y - 10 < ljunk[i].y)
                        {

                            ljunk[i].death = true;
                        }
                    }
                }
            }
        }

        private void Program1_Load(object sender, EventArgs e) //create awel mara el khalfeya w el characters etc
        {
            //for (int i = 1; i <= 5; i++)
            //{
            //    off = new Bitmap(ClientSize.Width, ClientSize.Height);
            //    back1 pnn = new back1();
            //    pnn.XD = 0;
            //    pnn.YD = 0;
            //    pnn.XS = 0;
            //    pnn.YS = 0;
            //    pnn.im = new Bitmap("Back" + i + ".png");
            //    //pnn.im.MakeTransparent(pnn.im.GetPixel(0, 0));
            //    lback.Add(pnn);
            //}
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            back1 pnn = new back1();
            pnn.XD = 0;
            pnn.YD = 0;
            pnn.XS = 0;
            pnn.YS = 0;
            pnn.im = new Bitmap("Background.png");
            //pnn.im.MakeTransparent(pnn.im.GetPixel(0, 0));
            lback.Add(pnn);
            background();
            create();
            createLadder();
            createShip();
        }

        private void Program1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(CreateGraphics());
        }
        bool frame;
        int ctbull;
        private void Tt_Tick(object sender, EventArgs e)
        {
            if (lzero[0].y >= ClientSize.Height) // lw el sha5seya we3t ta7t
            {
                tt.Stop();
                MessageBox.Show("ded");
            }
            if (bull)
            {
                if (ctbull >= 9)
                {
                    ctbull = 0;
                    frame = false;
                    bull = false;
                    shuriken pnn2 = new shuriken();
                    pnn2.x = lzero[0].x + 100;
                    pnn2.y = lzero[0].y + 30;
                    pnn2.img = new Bitmap("Kunai.png");
                    lshuriken.Add(pnn2);
                }
            }
            if (frame)
            {
                lzero[0].icurr++;
                ctbull++;
            }
            if (chesto) // lw weselt 3nd el chest
            {
                lchest[0].icurr++;
                if (lchest[0].icurr == 7)
                {
                    chesto = false;

                    sword pnn = new sword();
                    pnn.x = lchest[0].x + 10;
                    pnn.y = lchest[0].y - 10;
                    pnn.img = new Bitmap("Sword.png");
                    lsword.Add(pnn);
                    lchest.RemoveAt(0);
                }
            }
            for (int i = 0; i < lenemy.Count; i++) //ENEMY DYING
            {
                //animation el death bta3 el enemy
                if (lenemy[i].death == 1)
                {
                    //for (int j = 0; j < 4; j++)
                    //{
                    lenemy[i].icurr++;
                    //DrawDubb(CreateGraphics());
                    //}
                    if (lenemy[i].icurr == 8)
                        lenemy.RemoveAt(i);
                }
            }
            //if (state)
            //{
            //    lzero[0].icurr = 0;
            //    for (int i = 0; i < 10; i++)
            //    { 
            //        lzero[0].icurr++;
            //        DrawDubb(CreateGraphics()); 
            //    }

            //    state = false;
            //}
            shoot(); // el enemy bydrab
            for (int i = 0; i < lenemy.Count; i++)//Enemy shooting animation
            {
                if (lenemy[i].shoot && lenemy[i].death != 1)
                {
                    if (ct % 3 == 0)
                        lenemy[i].icurr++;

                    if (lenemy[i].icurr == 4)
                        lenemy[i].icurr = 0;
                }
            }
            for (int i = 0; i < lshuriken.Count; i++) //ENEMY GETTING SHOT animation
            {
                for (int j = 0; j < ljunk.Count; j++)
                {
                    if (lshuriken[i].x + 50 >= ljunk[j].x && lshuriken[i].x < ljunk[j].x
                        && lshuriken[i].y >= ljunk[j].y && lshuriken[i].y + 20 <= ljunk[j].y + 100)
                    {/*MessageBox.Show(i + " " + j);*/
                        ljunk[j].death = true;
                        lshuriken.RemoveAt(i); //remove el enemy after death
                        //lenemy.RemoveAt(j);
                        break;
                    }
                }
            }
            if (ct % 3 == 0)
            {
                if (lzero[0].icurr == 24)
                {
                    lzero[0].icurr++;
                }
            }

            lback[0].XS += 2; //MOVEMENT OF BACKGROUND
            if (lback[0].XS >= lback[0].im.Width / 2)
            {
                lback[0].XS = 0;
            }
            if (b == 0)
            {
                if (lback[b].XS >= lback[b].im.Width / 2)
                {
                    b++;
                    back1 pnn = new back1();
                    pnn.XD = ClientSize.Width + 1;
                    pnn.YD = 0;
                    pnn.XS = 0;
                    pnn.YS = 0;
                    pnn.im = new Bitmap("61.png");
                    lback.Add(pnn);
                }
            }
            if (ct % 60 == 0)  //CREATING RANDOM ENEMIES
                createEnemy();
            fly = true;
            gravity();
            moveElevator();
            movetransport();
            moveBullet();
            moveJunk();
            junkAttack();
            junkDeath();
            climb();
            if (sp == 1)
            {
                spear2();
            }
            if (ct % 20 == 0 && lship.Count > 0)
            {
                createLaser(CreateGraphics());
            }
            if (ct % 50 == 0)
                createCyborg();
            if (fly && !climb2)
            {
                lzero[0].y += 5;
                if (lzero[0].form != 1)
                    lzero[0].icurr = 26;
            }
            climb2 = false;
            for (int i = 0; i < lshuriken.Count; i++)
            {
                lshuriken[i].x += 30;
            }//MOVEMENT OF SHURIKEN
            if (ct % 30 == 0)
            {
                randomCreatures();
            }
            if (lcraft.Count != 0)
            {
                for (int i = 0; i < lcraft.Count; i++)
                {
                    lcraft[i].x -= 50;
                    if (ct % 20 == 0)
                    {
                        rocket pnn = new rocket();
                        pnn.x = lcraft[i].x;
                        pnn.y = lcraft[i].y + 50;
                        pnn.img = new Bitmap("Flag.png");
                        lrocket.Add(pnn);
                    }
                }
                for (int i = 0; i < lrocket.Count; i++)
                {
                    if (lrocket[i].y + 50 >= lzero[0].y && lrocket[i].y < lzero[0].y)
                    {
                        if ((lzero[0].x >= lrocket[i].x && lzero[0].x < lrocket[i].x + 20) ||
                        (lzero[0].x + 100 >= lrocket[i].x && lzero[0].x + 100 <= lrocket[i].x + 50) ||
                         lrocket[i].x >= lzero[0].x && lrocket[i].x <= lzero[0].x + 100)
                        {
                            lzero[0].death = true;

                        }
                    }
                }
            }
            if (lrocket.Count != 0)
            {
                for (int i = 0; i < lrocket.Count; i++)
                {
                    lrocket[i].y += 10;
                }
            }
            if (lzero[0].death)
            {
                death();
            }
            DrawDubb(CreateGraphics());
            ct++;
            //lzero[0].icurr++;
            if (lenemy.Count == 0 && ljunk.Count == 0)
            {
                tt.Stop();
                MessageBox.Show("You win");
            }
        }
        void createLaser(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, 0, lship[0].y + 20, lship[0].x, 10);
            if (lzero[0].y <= lship[0].y + 20 && lzero[0].y + 100 >= lship[0].y + 30)
            {
                lzero[0].death = true;
            }
        }
        void death()
        {
            lzero[0].icurr = 39;
            for (int j = 0; j < 10; j++)
            {
                lzero[0].icurr++;
                DrawDubb(CreateGraphics());
            }
            tt.Stop();
            MessageBox.Show("ded");
        }
        void background()
        {
            btile pnn;
            Bitmap im;
            int x = 180, y = ClientSize.Height - 240, j = 3;

            for (int i = 1; i <= 3; i++)
            {
                pnn = new btile();
                pnn.x = x;
                pnn.y = y;
                im = new Bitmap("IndustrialTile_05.png");
                //im.MakeTransparent(im.GetPixel(0, 0));
                j++;
                if (j > 6)
                {
                    j = 3;
                }
                pnn.img = im;
                x += 60;
                lbtile.Add(pnn);
            }
            y += 60;
            x = 180;
            for (int i = 1; i <= 9; i++)
            {
                pnn = new btile();
                pnn.x = x;
                pnn.y = y;
                im = new Bitmap("IndustrialTile_14.png");
                //im.MakeTransparent(im.GetPixel(0, 0));
                j++;
                if (j > 6)
                {
                    j = 3;
                }
                pnn.img = im;
                x += 60;
                if (i % 3 == 0)
                {
                    x = 180;
                    y += 60;
                }
                lbtile.Add(pnn);
            }
            x = 120; y = ClientSize.Height - 240;
            pnn = new btile();
            pnn.x = x;
            pnn.y = y;
            im = new Bitmap("IndustrialTile_04.png");
            pnn.img = im;
            lbtile.Add(pnn);
            x = 360;
            pnn = new btile();
            pnn.x = x;
            pnn.y = y;
            im = new Bitmap("IndustrialTile_06.png");
            pnn.img = im;
            lbtile.Add(pnn);
            x = 120;
            for (int i = 1; i <= 9; i++)
            {
                y += 60;
                pnn = new btile();
                pnn.x = x;
                pnn.y = y;
                im = new Bitmap("IndustrialTile_13.png");
                pnn.img = im;
                lbtile.Add(pnn);
            }
            x = 360; y = ClientSize.Height - 240;
            for (int i = 1; i <= 9; i++)
            {
                y += 60;
                pnn = new btile();
                pnn.x = x;
                pnn.y = y;
                im = new Bitmap("IndustrialTile_15.png");
                pnn.img = im;
                lbtile.Add(pnn);
            }
            btile2 pnn2;
            x = 420; y = ClientSize.Height - 60;
            for (int i = 0; i < 10; i++)
            {

                pnn2 = new btile2();
                pnn2.x = x;
                pnn2.y = y;
                im = new Bitmap("IndustrialTile_09.png");
                pnn2.img = im;
                l2btile.Add(pnn2);
                x += 60;
            }
            Random rr = new Random();
            x = 420; y -= 40;
            items pnn3;
            for (int i = 0; i < 5; i++)
            {
                pnn3 = new items();
                pnn3.x = rr.Next(x, 900);
                pnn3.y = y;
                int s = rr.Next(3, 5);
                im = new Bitmap("Locker" + s + ".png");
                pnn3.img = im;
                litems.Add(pnn3);
            }
            transport pnn4;
            x = 500;
            y = 500;
            for (int i = 0; i < 2; i++)
            {
                pnn4 = new transport();
                pnn4.x = x;
                pnn4.y = y;
                pnn4.dir = 0;
                im = new Bitmap("Transporternew.png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn4.img = im;
                ltransport.Add(pnn4);
                x = rr.Next(500, 900);
                y = 150;
            }
            x = ClientSize.Width - 120;
            y = ClientSize.Height - 240;
            for (int i = 0; i < 3; i++)
            {
                y += 60;
                pnn = new btile();
                pnn.x = x;
                pnn.y = y;
                im = new Bitmap("IndustrialTile_13.png");
                pnn.img = im;
                lbtile.Add(pnn);
            }
            x = ClientSize.Width - 120; y = ClientSize.Height - 240;
            pnn = new btile();
            pnn.x = x;
            pnn.y = y;
            im = new Bitmap("IndustrialTile_04.png");
            pnn.img = im;
            lbtile.Add(pnn);
            x += 60;
            pnn = new btile();
            pnn.x = x;
            pnn.y = y;
            im = new Bitmap("IndustrialTile_05.png");
            pnn.img = im;
            lbtile.Add(pnn);

            y += 60;
            for (int i = 0; i < 3; i++)
            {
                pnn = new btile();
                pnn.x = x;
                pnn.y = y;
                y += 60;
                im = new Bitmap("IndustrialTile_14.png");
                //im.MakeTransparent(im.GetPixel(0, 0));
                pnn.img = im;
                lbtile.Add(pnn);
            }
            chest pnn5 = new chest();
            pnn5.x = ClientSize.Width - 70;
            pnn5.y = ClientSize.Height - 300;
            pnn5.icurr = 0;
            for (int i = 1; i <= 8; i++)
            {
                im = new Bitmap("Chest" + i + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn5.lchests.Add(im);
            }
            lchest.Add(pnn5);
            elevator pnn6 = new elevator();
            pnn6.x = ClientSize.Width - 240;
            pnn6.y = ClientSize.Height - 50;
            pnn6.dir = 0;
            pnn6.img = new Bitmap("Transporternew.png");
            pnn6.img.MakeTransparent(pnn6.img.GetPixel(0, 0));
            lelevator.Add(pnn6);
            x = 700;
            y = 300;
            for (int i = 0; i < 10; i++)
            {
                pnn2 = new btile2();
                pnn2.x = x;
                pnn2.y = y;
                im = new Bitmap("IndustrialTile_09.png");
                pnn2.img = im;
                l2btile.Add(pnn2);
                x += 60;
            }
        }
        void randomCreatures() //create el f16 elly foo2
        {
            Random r = new Random();
            f16 pnn = new f16();
            pnn.x = r.Next(ClientSize.Width + 100, ClientSize.Width + 1000);
            pnn.y = 10;
            pnn.img = new Bitmap("Air.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            lcraft.Add(pnn);
        }
        void shoot()
        {
            for (int i = 0; i < lenemy.Count; i++)
            {
                if ((lzero[0].y - lenemy[i].y) >= -30)
                {
                    lenemy[i].shoot = true;
                    if (ct % 20 == 0)
                    {
                        eBullet pnn = new eBullet();
                        pnn.x = lenemy[i].x - 5;
                        pnn.y = lenemy[i].y + 10;
                        pnn.img = new Bitmap("Bullet2.png");
                        pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                        lbullet.Add(pnn);
                    }
                }
            }
        }
        void gravity()
        {
            for (int i = 0; i < lbtile.Count; i++)
            {
                if (lzero[0].y + 100 >= lbtile[i].y)
                {
                    if ((lzero[0].x >= lbtile[i].x && lzero[0].x < lbtile[i].x + 60) ||
                        (lzero[0].x <= lbtile[i].x + 60 && lzero[0].x + 100 > lbtile[i].x + 60))
                    {
                        fly = false;
                    }
                }
            }
            for (int i = 0; i < l2btile.Count; i++)
            {

                if (lzero[0].y + 100 >= l2btile[i].y && lzero[0].y < l2btile[i].y)
                {
                    if (lzero[0].x >= l2btile[i].x && lzero[0].x < l2btile[i].x + 60)
                    {
                        fly = false;
                    }
                }
            }
            for (int i = 0; i < ltransport.Count; i++)
            {
                if (lzero[0].y + 100 - ltransport[i].y >= 5 && lzero[0].y < ltransport[i].y + 30
                 && lzero[0].y + 100 - ltransport[i].y < 10)
                {
                    if ((lzero[0].x + 50 >= ltransport[i].x && lzero[0].x + 100 <= ltransport[i].x + 200) ||
                       (lzero[0].x > ltransport[i].x && lzero[0].x < ltransport[i].x + 150))
                    {
                        fly = false;
                        movealong = true;
                        k = ltransport[i].dir;
                    }
                }
            }

            if (lzero[0].y + 100 >= lelevator[0].y && lzero[0].y < lelevator[0].y
             && lzero[0].y + 100 - lelevator[0].y < 10)
            {
                if ((lzero[0].x + 50 >= lelevator[0].x && lzero[0].x + 100 <= lelevator[0].x + 120) ||
                   (lzero[0].x > lelevator[0].x && lzero[0].x < lelevator[0].x + 50))
                {
                    fly = false;
                    movealong2 = true;
                }
            }

        }
        void moveBullet()
        {
            for (int i = 0; i < lbullet.Count; i++)
            {
                lbullet[i].x -= 10;
                if (lbullet[i].x < lzero[0].x + 100 && lbullet[i].x > lzero[0].x)
                {
                    if (lbullet[i].y >= lzero[0].y && lbullet[i].y < lzero[0].y + 100)
                        lzero[0].death = true;
                }
            }
        }
        void create() // create el map
        {
            Bitmap im;
            zero pnn = new zero();
            pnn.x = 300;
            pnn.y = 450;
            pnn.form = 0;
            for (int i = 0; i < 10; i++)
            {
                im = new Bitmap("Idle__00" + i + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn.lzero2.Add(im);
            }
            for (int i = 0; i < 10; i++)
            {
                im = new Bitmap("Run__00" + i + ".png");

                im.MakeTransparent(im.GetPixel(0, 0));
                pnn.lzero2.Add(im);
            }
            for (int i = 0; i < 4; i++)
            {
                im = new Bitmap(i + 1 + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn.lzero2.Add(im);
            }
            im = new Bitmap("20.png");
            im.MakeTransparent(im.GetPixel(0, 0));
            pnn.lzero2.Add(im);
            im = new Bitmap("21.png");
            im.MakeTransparent(im.GetPixel(0, 0));
            pnn.lzero2.Add(im);
            pnn.icurr = 0;
            lzero.Add(pnn);
            for (int i = 0; i < 9; i++)
            {
                im = new Bitmap("Glide_00" + i + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn.lzero2.Add(im);
            }
            for (int i = 0; i < 9; i++)
            {
                im = new Bitmap("Throw__00" + i + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn.lzero2.Add(im);
            }
            for (int i = 0; i < 10; i++)
            {
                im = new Bitmap("Dead__00" + i + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn.lzero2.Add(im);
            }

        }
        void createCyborg() //create noo3 tany men el enemy
        {
            Random r = new Random();
            cyborg pnn2 = new cyborg();
            pnn2.y = ClientSize.Height - 130;
            pnn2.x = r.Next(600, 1000);
            for (int i = 1; i <= 4; i++)
            {
                Bitmap im = new Bitmap("Cyborg" + i + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn2.lcyborg.Add(im);
            }
            for (int i = 1; i <= 5; i++)
            {
                Bitmap im = new Bitmap("CyborgDeath" + i + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn2.lcyborg.Add(im);
            }
            lenemy.Add(pnn2);
        }
        void createEnemy()
        {
            Random r = new Random();
            junk pnn2 = new junk();
            pnn2.y = 200;
            pnn2.x = r.Next(700, 1000);
            for (int i = 1; i <= 33; i++)
            {
                Bitmap im = new Bitmap("Punk" + i + ".png");
                im.MakeTransparent(im.GetPixel(0, 0));
                pnn2.ljunks.Add(im);
            }
            ljunk.Add(pnn2);
        }
        void moveJunk() // enemy byt7arak
        {

            for (int i = 0; i < ljunk.Count; i++)
            {
                if (ljunk[i].death != true)
                {
                    if (ljunk[i].dir == 0)
                    {
                        ljunk[i].x += 5;
                        ljunk[i].icurr++;
                        if (ljunk[i].icurr < 8 || ljunk[i].icurr > 13)
                        {
                            ljunk[i].icurr = 8;
                        }
                    }
                    else
                    {
                        ljunk[i].x -= 5;
                        ljunk[i].icurr++;
                        if (ljunk[i].icurr < 22 || ljunk[i].icurr > 27)
                        {
                            ljunk[i].icurr = 22;
                        }
                    }
                    if (ljunk[i].x >= 1250)
                    {
                        ljunk[i].dir = 1;
                    }
                    if (ljunk[i].x <= 700)
                    {
                        ljunk[i].dir = 0;
                    }
                }
            }
        }
        void junkAttack() // enemy attack
        {
            for (int i = 0; i < ljunk.Count; i++)
            {
                if (ljunk[i].x < lzero[0].x + 100 && ljunk[0].x + 60 > lzero[0].x + 100)
                {
                    if (ljunk[i].y >= lzero[0].y && ljunk[i].y < lzero[0].y + 100)
                    {
                        ljunk[i].icurr = 15;
                        lzero[0].icurr = 39;
                        for (int j = 0; j < 10; j++)
                        {
                            if (j < 7)
                                ljunk[i].icurr++;
                            lzero[0].icurr++;
                            DrawDubb(CreateGraphics());
                        }
                        tt.Stop();
                        MessageBox.Show("ded");
                    }
                }
                if (lzero[0].x <= ljunk[i].x + 60 && lzero[0].x > ljunk[i].x)
                {
                    if (ljunk[i].y >= lzero[0].y && ljunk[i].y < lzero[0].y + 100)
                    {
                        ljunk[i].icurr = 0;
                        lzero[0].icurr = 39;
                        for (int j = 0; j < 10; j++)
                        {
                            lzero[0].icurr++;
                            DrawDubb(CreateGraphics());
                            if (j < 7)
                                ljunk[i].icurr++;

                        }
                        tt.Stop();
                        MessageBox.Show("ded");
                    }
                }
            }
        }
        void junkDeath() // enemy death
        {
            for (int i = 0; i < ljunk.Count; i++)
            {
                if (ljunk[i].death == true)
                {
                    if (ljunk[i].icurr < 28)
                        ljunk[i].icurr = 28;

                    ljunk[i].icurr++;

                    if (ljunk[i].icurr == 32)
                        ljunk.RemoveAt(i);
                }
            }
        }
        void movetransport() //bet7arak el ard ymeen w shemal
        {
            for (int i = 0; i < ltransport.Count; i++)
            {
                if (ltransport[i].dir == 0)
                {
                    ltransport[i].x += 15;
                    if (k == 0)
                    {
                        if (movealong)
                        {
                            movealong = false;
                            lzero[0].x += 15;
                        }
                    }
                }
                else
                {
                    ltransport[i].x -= 15;
                    if (k == 1)
                    {
                        if (movealong)
                        {
                            movealong = false;
                            lzero[0].x -= 15;
                        }
                    }
                }
                if (ltransport[i].x + 200 >= ClientSize.Width)
                {
                    ltransport[i].dir = 1;
                    if (k == 1)
                        k = 0;
                }
                if (ltransport[i].x <= 0)
                {
                    ltransport[i].dir = 0;
                    if (k == 1)
                        k = 0;
                }
            }
        }
        void moveElevator() //bet7arak el elevator
        {
            int y = ClientSize.Height - 240;
            if (lelevator[0].dir == 0)
            {
                lelevator[0].y -= 5;
                if (movealong2)
                {
                    movealong = false;
                    lzero[0].y -= 5;
                }
            }

            if (lelevator[0].dir == 1)
            {
                lelevator[0].y += 5;
                if (movealong2)
                {
                    movealong = false;
                    lzero[0].y += 5;
                }
            }
            if (lelevator[0].y <= y)
            {
                lelevator[0].dir = 1;
            }
            if (lelevator[0].y >= ClientSize.Height - 40)
            {
                lelevator[0].dir = 0;
            }
        }
        void createLadder()
        {
            ladder pnn = new ladder();
            pnn.x = 200;
            pnn.y = 160;
            pnn.img = new Bitmap("Ladder1.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            lladder.Add(pnn);
        }
        void createShip() //bte3mel el sela7 elly bydrab laser
        {
            ship pnn = new ship();
            pnn.x = ClientSize.Width - 130;
            pnn.y = 300;
            pnn.img = new Bitmap("Turret.png");
            lship.Add(pnn);
        }
        int sp = 0;
        void spear2() // el spear elly btermeeh b F 
        {
            if (sp == 0)
            {
                sp++;
                spear pnn = new spear();
                pnn.x = lzero[0].x + 100;
                pnn.y = lzero[0].y + 20;
                pnn.img = new Bitmap("Spear2.png");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                lspear.Add(pnn);
            }
            lspear[0].x += 30;
            if (lship.Count != 0)
            {
                if (lspear[0].x >= lship[0].x)
                {
                    if (lspear[0].y >= lship[0].y && lspear[0].y + 50 <= lship[0].y + 200)
                    {
                        lship.RemoveAt(0);
                    }
                }
            }
        }
        void climb()
        {
            if (lzero[0].x >= lladder[0].x && lzero[0].x + 100 < lladder[0].x + 150)
            {
                climb2 = true;
            }
        }
        void DrawScene(Graphics g)
        {
            g.Clear(Color.White);

            for (int i = 0; i < lback.Count; i++)
            {
                Rectangle rcDest = new Rectangle(lback[i].XD, lback[i].YD,
                                                    //(int)(LActs[i].im.Widthratio) , 
                                                    //(int)(LActs[i].im.Height ratio));
                                                    ClientSize.Width,
                                                    ClientSize.Height);

                Rectangle rcSrc = new Rectangle(lback[i].XS, lback[i].YS,
                                                lback[i].im.Width / 2, lback[i].im.Height);
                //LActs[i].im.Width, LActs[i].im.Height);
                g.DrawImage(lback[i].im,
                            rcDest, rcSrc,
                            GraphicsUnit.Pixel
                            );
            }
            for (int i = 0; i < lbtile.Count; i++)
            {
                g.DrawImage(lbtile[i].img,
                            lbtile[i].x,
                            lbtile[i].y, 60, 60);
            }
            for (int i = 0; i < l2btile.Count; i++)
            {
                g.DrawImage(l2btile[i].img,
                            l2btile[i].x,
                            l2btile[i].y, 60, 60);
            }
            for (int i = 0; i < litems.Count; i++)
            {
                g.DrawImage(litems[i].img,
                            litems[i].x,
                            litems[i].y, 40, 40);
            }
            for (int i = 0; i < ltransport.Count; i++)
            {
                g.DrawImage(ltransport[i].img,
                            ltransport[i].x,
                            ltransport[i].y, 200, 30);
            }
            for (int i = 0; i < lshuriken.Count; i++)
            {
                g.DrawImage(lshuriken[i].img,
                           lshuriken[i].x,
                           lshuriken[i].y, 50, 15);
            }
            for (int i = 0; i < lcraft.Count; i++)
            {
                g.DrawImage(lcraft[i].img,
                           lcraft[i].x,
                           lcraft[i].y, 100, 50);
            }
            for (int i = 0; i < lrocket.Count; i++)
            {
                g.DrawImage(lrocket[i].img,
                           lrocket[i].x,
                           lrocket[i].y, 20, 50);
            }
            g.DrawImage(lelevator[0].img, lelevator[0].x, lelevator[0].y, 120, 30);
            if (lchest.Count != 0)
                g.DrawImage(lchest[0].lchests[lchest[0].icurr], lchest[0].x, lchest[0].y, 70, 65);
            if (lsword.Count != 0)
                g.DrawImage(lsword[0].img, lsword[0].x, lsword[0].y, 50, 100);
            //MessageBox.Show(lenemy.Count + " ");       
            for (int i = 0; i < lenemy.Count; i++)
            {
                g.DrawImage(lenemy[i].lcyborg[lenemy[i].icurr],
                            lenemy[i].x,
                            lenemy[i].y, 60, 70);
            }
            for (int i = 0; i < ljunk.Count; i++)
            {
                g.DrawImage(ljunk[i].ljunks[ljunk[i].icurr],
                            ljunk[i].x,
                            ljunk[i].y, 60, 100);
            }
            for (int i = 0; i < lbullet.Count; i++)
            {
                g.DrawImage(lbullet[i].img,
                            lbullet[i].x,
                            lbullet[i].y, 50, 20);
            }
            g.DrawImage(lladder[0].img, lladder[0].x, lladder[0].y, 90, 400);
            if (lship.Count != 0)
                g.DrawImage(lship[0].img, lship[0].x, lship[0].y, 150, 200);
            if (lspear.Count != 0)
                g.DrawImage(lspear[0].img, lspear[0].x, lspear[0].y, 100, 50);
            g.DrawImage(lzero[0].lzero2[lzero[0].icurr], lzero[0].x, lzero[0].y, 100, 100);
            if (linel.Count != 0)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawLine(pen, linel[0].x, linel[0].y, linel[0].x2, linel[0].y2);
                g.FillRectangle(Brushes.Black, linel[0].x, linel[0].y, 2, 5);
            }
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
        static void Main()
        {
            program1 obj;
            obj = new program1();
            Application.Run(obj);
        }
    }
}