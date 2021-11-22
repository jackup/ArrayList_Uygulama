using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList uList = new ArrayList();
            int choice = 0;

            Console.WriteLine("Liste düzenleme uygulamasına hoşgeldiniz.\n");

            do
            {
                Console.WriteLine("Lütfen menüden yapmak istediğiniz işlemi seçin : ");
                Console.WriteLine("Menü :\n1 : Değer Ekle\n2 : Değer Listele\n3 : Değer Ara\n4 : Değer Düzenle\n5 : Değer Sil\n6 : Uygulama Çıkış");
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Eklenecek veriyi girin : ");
                        string veri = Console.ReadLine();
                        uList.Add(veri);
                        Console.WriteLine("Değer başarıyla eklendi.");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Listedeki veriler yazdırılıyor :");
                        foreach (var item in uList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Aranacak değeri girin :");
                        string ara = Console.ReadLine();
                        int index = uList.IndexOf(ara);
                        if (index >= 0)
                        {
                            Console.WriteLine("Değer dizide {0}. indexte bulunmaktadır.", index);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer dizide yoktur!");
                            Console.WriteLine("Bu değeri listeye eklemek ister misiniz? (e/h)");
                            char eh = char.Parse(Console.ReadLine());
                            if (eh == 'e')
                            {
                                uList.Add(ara);
                                Console.WriteLine("Değer listeye başarıyla eklendi");
                            }
                            else
                            {
                                Console.WriteLine("Değer listeye eklenmedi.");
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Düzenlenecek değeri girin :");
                        string v = Console.ReadLine();
                        if (uList.Contains(v))
                        {
                            int vI = uList.IndexOf(v);
                            Console.WriteLine("Yeni değeri girin :");
                            string d = Console.ReadLine();
                            uList[vI] = d;
                            Console.WriteLine("Değer güncellendi!");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz değer listede bulunmamaktadır.");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Silmek istediğiniz değeri girin :");
                        string s = Console.ReadLine();
                        if (uList.Contains(s))
                        {
                            uList.Remove(s);
                            Console.WriteLine("Değer Silindi!");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz değer listede bulnmamaktadır.");
                        }
                        break;
                    default:
                        break;
                }
            } while (choice > 0 && choice < 6);
        }
    }
}
