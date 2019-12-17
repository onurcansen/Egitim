using Framework.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOB.WinUI
{
    public partial class FormMainCustomer : Form
    {
        public FormMainCustomer()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //ss
        }

        private void caramelMacchiatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CM = "Caramel Macchiato";
            string CaramelMacchiato = "Vanilya şurubu, buharla ısıtılmış süt, süt köpüğüne eklenen espresso ve karamel. Alerjenler: Süt,Soya)";
           // grbInformation.Enabled = true;
            txtExplanation.Text = CaramelMacchiato;
            txtProductName.Text = CM;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\CARAMEL MACCHIATO.jpg");
        }

        private void flatWhiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string FW = "Flat White";
            string FlatWhite = "Lattesini daha yoğun kahve ile tercih edenler için süt ile espressonun kusursuz dengesi. Alerjenler: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = FlatWhite;
            txtProductName.Text = FW;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\FLAT WHİTE.jpg");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //grbInformation.Enabled = false;
            // txtProductName.BackColor = TransparencyKey;
            txtProductName.ReadOnly = true;
            
        }

        private void dOBCARDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ristrettoBiancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string RB = "Ristretto Bianco";
            string RistrettoBianco = "Özel ristretto shot ve ustalıkla ısıtılmış süte latte sanatı ile zarif bir dokunuş. Alerjen: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = RistrettoBianco;
            txtProductName.Text = RB;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\RİSTRETTO BIANCO.jpg");
        }

        private void caffèAmericanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CA = "Caffe Americano";
            string CaffeAmericano = "Yoğun espressonun sıcak su ile inceltilmesi. Alerjen içermez.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = CaffeAmericano;
            txtProductName.Text = CA;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\AMERİCANO.jpg");
        }

        private void caffèLatteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CL = "Caffe Latte";
            string CaffeLatte = "Espresso shot'a buharda özenle ısıtılmış sütün kadifemsi dokunuşu. Alerjenler: Süt";
           // grbInformation.Enabled = true;
            txtExplanation.Text = CaffeLatte;
            txtProductName.Text = CL;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\LATTE.jpg");
            
        }

        private void caffèMochaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CM = "Caffe Mocha";
            string CaffeMocha = "Buharla ısıtlmış süt, espresso shot, nefis krema ve mochanın lezzetiyle bir arada. Alerjenler: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = CaffeMocha;
            txtProductName.Text = CM;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\CAFFE MOCHA.jpg");
        }

        private void whiteChocolateMochaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string WCM = "White Chocolate Mocha";
            string WhiteChocolateMocha = "Espresso shot, beyaz çikolata, krema ve buharla ısıtılmış süt sizin için buluştu. Alerjenler: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = WhiteChocolateMocha;
            txtProductName.Text = WCM;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\WHİTE CHOCOLATE MOCHA.jpg");

        }

        private void cappuccinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string C = "Cappuccino";
            string Cappuccino = "Espresso üstünde bol köpük ve buharla ısıtılmış süt ile karşınızda: Cappuccino! Alerjenler: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = Cappuccino;
            txtProductName.Text = C;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\CAPPUCCINO.jpg");
        }

        private void espressoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string E = "Espresso";
            string Espresso = "Sizin için özenle kavrulmuş espresso lezzeti. Alerjen içermez.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = Espresso;
            txtProductName.Text = E;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\ESPRESSO.jpg");
        }

        private void espressoConPannaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ECP = "Espresso Con Panna";
            string EspressoConPanna = "Espresso ve krema, zengin karamel lezzetiyle! Alerjenler: Süt";
           // grbInformation.Enabled = true;
            txtExplanation.Text = EspressoConPanna;
            txtProductName.Text = ECP;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\ESPRESSO CON PANNA.jpg");
        }

        private void espressoMacchiatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string EspressoMacchiato = "Espressonun eşsiz lezzeti, buharla ısıtılmış süt ve köpükle yeniden yaratıldı. Alerjenler: Süt.";
            string EM = "Espresso Macchiato";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = EspressoMacchiato;
            txtProductName.Text = EM;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\ESPRESSO MACCIATO.jpg");
        }

        private void buzluCaffèAmericanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BCA = "Buzlu Caffe Americano";
            string BuzluCaffeAmericano = "Suyla seyreltilmiş zengin espresso shot'ın buzla lezzeti. Alerjen içermez.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = BuzluCaffeAmericano;
            txtProductName.Text = BCA;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\BUZLU AMERİCANO.jpg");
        }

        private void buzluCaffèLatteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BCL = "Buzlu Caffe Latte";
            string BuzluCaffeLatte = "Bir bardak dolusu buzlu ve sütlü espresso lezzeti. Alerjenler: Süt.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = BuzluCaffeLatte;
            txtProductName.Text = BCL;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\BUZLU LATTE.jpg");
        }

        private void buzluCaffèMochaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BCM = "Buzlu Caffe Mocha";
            string BuzluCaffeMocha = "Zengin ve dolgun gövdeli espresso shot, mocha, soğuk süt, buz ve nefis krema. Alerjenler: Süt.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = BuzluCaffeMocha;
            txtProductName.Text = BCM;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\BUZLU CARAMEL MACCIATO.jpg");
        }

        private void buzluWhiteChocolateMochaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BWC = "Buzlu White Chocolate Mocha";
            string BuzluWhiteChocolateMocha = "Eşsiz espressomuzu bir de white mocha, süt, buz ve kremayla deneyin. Alerjenler: Süt.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = BuzluWhiteChocolateMocha;
            txtProductName.Text = BWC;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\WHITE CHOCOLATE MOCHA.jpg");
        }

        private void buzluCaramelMacchiatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BCMT = "Buzlu Caramel Macchiato";
            string BuzluCaramelMacchiato = "Eşsiz espressomuzu bir de karamel mocha, süt, buz ve kremayla deneyin. Alerjenler: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = BuzluCaramelMacchiato;
            txtProductName.Text = BCMT;
            pictureBox1.Load(Application.StartupPath+"\\..\\..\\Resources\\BUZLU CARAMEL MACCIATO.jpg");
        }

        private void filtreKahveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string FK = "Filtre Kahve";
            string FilteKahve = "Günün her saatinde sizi canlandıracak sade filtre kahve. Alerjen içermez.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = FilteKahve;
            txtProductName.Text = FK;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Resources\\FILTRE KAHVE.jpg");
        }

        private void buzluFiltreKahveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BFK = "Buzlu Filtre Kahve";
            string BuzluFilteKahve = "Günün her saatinde sizi canlandıracak buzlu filtre kahve. Alerjen içermez.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = BuzluFilteKahve;
            txtProductName.Text = BFK;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Resources\\BUZLU FILTRE KAHVE.jpg");
        }

        private void caffèMistoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CMisto = "Caffe Misto";
            string CaffeMisto = "Filtre kahvenize buharda ustalıkla ısıtılmış süt ile yumuşak bir dokunuş. Alerjenler: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = CaffeMisto;
            txtProductName.Text = CMisto;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Resources\\CAFE MISTO.jpg");
        }

        private void buzluMistoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BuzluM = "Buzlu Misto";
            string BuzluMisto = "Filtre kahvenize buzlu süt ile yumuşak bir dokunuş. Alerjenler: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = BuzluMisto;
            txtProductName.Text = BuzluM;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Resources\\BUZLU MISTO.jpg");
        }

        private void coldBrewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string COB = "Cold Brew";
            string ColdBrew = "İri çekilmiş kahve çekirdeklerinin 20 saat boyunca soğuk suda demlenmesiyle hazırlanmış soğuk kahve. Alerjen içermez.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = ColdBrew;
            txtProductName.Text = COB;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Resources\\COLD BREW.jpg");
        }

        private void sütlüColdBrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SCB = "Sütlü Cold Brew";
            string SutluColdBrew = "İri çekilmiş kahve çekirdeklerinin 20 saat boyunca soğuk suda demlenmesiyle hazırlanmış buzlu kahve. Alerjen içermez.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = SutluColdBrew;
            txtProductName.Text = SCB;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Resources\\SUTLU COLD BREW.jpg");
        }

        private void coffeeFrappuccinoBlendedBeverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string COFB = "Coffe Frappuccino";
            string CoffeFrappuccinoBlender = "Kahve ve sütün buz parçaları ile buluştuğu keyifli lezzet! Alerjenler: Süt.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = CoffeFrappuccinoBlender;
            txtProductName.Text = COFB;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Resources\\COFFEE FRAPPUCCINO.jpg");
        }

        private void espressoFrappuccinoBlendedBeverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ESF = "Espresso Frappuccino";
            string EspressoFrappuccinoBlender = "Coffee Frappuccino ve espressonun muhteşem uyumu. Alerjenler: Süt";
           // grbInformation.Enabled = true;
            txtExplanation.Text = EspressoFrappuccinoBlender;
            txtProductName.Text = ESF;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Resources\\ESPRESSO FRAPPUCCINO.jpg");
        }

        private void caramelFrappuccinoBlendedBeverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CAF = "Caramel Frappuccino";
            string CaramelFrappuccinoBlender = "Kahve, süt, karamel şurubu ve kar haline getirilmiş buz parçalarının krema ve karamel sos ile sunumu. Alerjenler: Süt, Soya.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = CaramelFrappuccinoBlender;
            txtProductName.Text = CAF;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Recources\\CARAMEL FRAPPUCCINO.jpg");
        }

        private void mochaFrappuccinoBlendedBeverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MOF = "Mocha Frappuccino";
            string MochaFrappuccinoBlender = "Kahve, süt, mocha sosu karışımının kar haline getirilmiş buz parçaları ile birleşmesiyle elde edilen özel kahveli karışımı: Mocha Frappuccino. Alerjenler: Süt";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = MochaFrappuccinoBlender;
            txtProductName.Text = MOF;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Recources\\MOCHA FRAPPUCCINO.jpg");
        }

        private void javaChipFrappuccinoBlendedBeverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string JCF = "Java Chip Frappuccino";
            string JavaChipFrappuccinoBlender = "Süt, mocha sos, kakao taneciklerinin kar haline getirilmiş buz, krema ve çikolata sosu ile buluşması. Alerjenler: Süt, Soya, Gluten.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = JavaChipFrappuccinoBlender;
            txtProductName.Text = JCF;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Recources\\JAVA CHİP FRAPPUCCINO");
        }

        private void whiteChocolateCreamFrappuccinoBlendedBeverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string WCCF = "Whitw Chocolate Cream Frappuccino";
            string WhiteChocolateCreamFrappuccinoBlender = "Süt, buz ve kremanın buluşmasıyla ortaya çıkan beyaz çikolatalı lezzeti. Alerjenler: Süt.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = WhiteChocolateCreamFrappuccinoBlender;
            txtProductName.Text = WCCF;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Recources\\WHITE CHOCOLATE FRAPPUCCINO.jpg");
        }

        private void chocolateFrappuccinoBlendedBeverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CHF = "Chocolate Frappuccino";
            string ChocolateFrappuccinoBlender = "Süt, buz ve kremanın buluşmasıyla ortaya çıkan sütlü çikolatalı lezzeti. Alerjenler: Süt.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = ChocolateFrappuccinoBlender;
            txtProductName.Text = CHF;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Recources\\CHOCOLATE FRAPPUCCINO.jpg");
        }

        private void classicHotChocolateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CHC = "Classic Hot Chocolate";
            string ClassicHotChocolate = "Buharla ısıtılmış süt, mocha sosu, vanilya şurubu, krema.Alerjen: Süt";
           // grbInformation.Enabled = true;
            txtExplanation.Text = ClassicHotChocolate;
            txtProductName.Text = CHC;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Recources\\CLASSIC HOT CHOCOLATE.jpg");
        }

        private void starbucksSignatureHotChocolateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SHC = "Signature Hot Chocolate";
            string signatureHotChocolate = "Özel toz karışımımız, krema ve kakao tozu. Tercihegöre Fındık ve Karamel şurup ilave edilebilir.Alerjen: Süt, Az miktarda soya içerebilir.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = signatureHotChocolate;
            txtProductName.Text = SHC;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Recources\\SIGNATURE HOT CHOCOLATE.jpg");
        }

        private void türkKahvesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TK = "Türk Kahvesi";
            string TurkKahvesi = "Geleneksel Türk kahvesinin DOB Veranda Blend çekirdek kahvesi ile yorumlandığı Türk kahvesi. Alerjen içermez.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = TurkKahvesi;
            txtProductName.Text = TK;
        }

        private void doubleTürkKahvesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string DTK = "Double Türk Kahvesi";
            string DoubleTurkKahvesi = "Geleneksel Türk kahvesinin DOB Veranda Blend çekirdek kahvesi ile yorumlandığı Double Türk kahvesi. Alerjen içermez.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = DoubleTurkKahvesi;
            txtProductName.Text = DTK;
        }

        private void earlGreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string EG = "Earl Grey";
            string EarlGrey = "Geleneksel siyah çayın bergamot ve lavanta çiçeği özü ile eşşsiz uyumu. Alerjen içermez.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = EarlGrey;
            txtProductName.Text = EG;
        }

        private void englishBreakfastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string EB = "English Breakfast";
            string EnglishBreakfast = "Sadece kahvaltıda değil, günün her saatinde keyifle tadabileceğiniz siyah çay. Alerjen içermez.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = EnglishBreakfast;
            txtProductName.Text = EB;
        }

        private void chaiTeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CHT = "Chai Tea";
            string ChaiTea = "Hindistan'dan gelen; zencefil, tarçın, karabiber, kakule ve karanfilin, yıldız anasonla buluşmasıyla ortaya çıkan lezzet. Alerjen içermez.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = ChaiTea;
            txtProductName.Text = CHT;
        }

        private void mintBlendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MB = "Mint Blend";
            string MintBlend = "Siyah çay ve nanenin ferahlatıcı birlikteliği. Alerjen içermez.";
          //  grbInformation.Enabled = true;
            txtExplanation.Text = MintBlend;
            txtProductName.Text = MB;
        }

        private void spearmintGreenTeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MB = "Spearmin Green Tea";
            string MintBlend = "Özel yeşil çayın,nanenin ferahlatıcı birlikteliği.  Alerjen içermez.";
           // grbInformation.Enabled = true;
            txtExplanation.Text = MintBlend;
            txtProductName.Text = MB;
        }

        private void chaiTeaLatteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CTL = "Chai Tea Latte";
            string ChaiTeaLatte = "Siyah çay ve bitki özü karışımının sıcak su ile inceltilmesi,üzerine eklenen buharla ısıtılmış süt. Alerjen: Süt";
           // grbInformation.Enabled = true;
            txtExplanation.Text = ChaiTeaLatte;
            txtProductName.Text = CTL;
        }

        private void buzluChaiTeaLatteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BCTL = "Buzlu Chai Tea Latte";
            string BuzluChaiTeaLatte = "Siyah çay ve bitki özü karışımının sıcak su ile inceltilmesi,üzerine eklenen buzlu süt. Alerjen: Süt";
            //grbInformation.Enabled = true;
            txtExplanation.Text = BuzluChaiTeaLatte;
            
            txtProductName.Text = BCTL;
            // Textbox1.ReadOnly = False;
           
            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //fare üzerine gelince büyüyen resim eklenecek
        }

        private void grbInformation_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salatalarrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //customer Account güncelle formu
        }

        private void ShoppingUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrderAdd frm = new FormOrderAdd();
            frm.Show();
            this.Close();

        }

        private void BasketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrderList frm = new FormOrderList();
            frm.Show();
            this.Close();
            // bu form düzenlencek..
        }

        private void dOBCardNedirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string DobCard = "DOB CARD";
            string aciklama = "DOB Card, DOB Türkiye mağazalarından satın alınabilecek, ön ödemeli ve tekrar yükleme özelliği bulunan bir avantaj kartıdır. İçerisine bakiye yüklediğiniz DOB Card'ınızı mağazalarımızda gerçekleştireceğiniz alışverişlerinizde kullanabilir ya da sevdiklerinize hediye edebilirsiniz.";
          
            txtExplanation.Text = aciklama;
            txtProductName.Text = DobCard;
            pictureBox1.Load(Application.StartupPath + "\\..\\..\\Recources\\325uncoatedbc.jpg");

        }
    }
}
