using RentACar.Lib;

namespace RentACar;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

   
    private void Form1_Load(object sender, EventArgs e)
    {
        Otomobil yeniOtomobil = new Otomobil();
        yeniOtomobil.Marka = ($"Mercedes, BMW, Nissan, Opel, Volkswagen, Renault, Range Rover");
        yeniOtomobil.Model = ($"X,Y,Z,W");
        yeniOtomobil.Renk = ($"Siyah,Beyaz,Gri,K�rm�z�,Mavi");
        yeniOtomobil.Yak�tTuru = ("Dizel,Benzin,LBG,Elektrik,Hibrit");
        yeniOtomobil.Stok = (500);
       
        
        Kamyon yeniKamyon=new Kamyon(); 
        yeniKamyon.Marka= ($"Mercedes, BMW, Nissan, Opel, Volkswagen, Renault, Range Rover");
        yeniKamyon.Model = ($"X,Y,Z,W");
        yeniKamyon.Renk = ($"Siyah,Beyaz,Gri,K�rm�z�,Mavi");
        yeniKamyon.Yak�tTuru = ("Dizel,Benzin,LBG,Elektrik,Hibrit");
        yeniKamyon.Stok= (150); 

        Motosiklet yeniMotosiklet=new Motosiklet();
        yeniMotosiklet.Marka = ($", , , , , , ");
        yeniMotosiklet.Model = ($"X,Y,Z,W");
        yeniMotosiklet.Renk = ($"Siyah,Beyaz,Gri,K�rm�z�,Mavi,Pembe,Turuncu,Sar�");
        yeniMotosiklet.Yak�tTuru = ("Dizel,Benzin,Elektrik");
        yeniMotosiklet.Stok=(5000);  
        
        OtoMiniBus yeniotoMiniBus= new OtoMiniBus();
        yeniotoMiniBus.Marka = ($"Mercedes, BMW, Nissan, Opel, Volkswagen, Renault, Range Rover");
        yeniotoMiniBus.Model = ($"X,Y,Z,W");
        yeniotoMiniBus.Renk = ($"Siyah,Beyaz,Gri,K�rm�z�,Mavi");
        yeniotoMiniBus.Yak�tTuru = ("Dizel,Benzin,LBG,Elektrik,Hibrit");
        yeniotoMiniBus.Stok = (600);
    }
  
}