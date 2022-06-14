using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace BinarySearchTree
{
    public class node
    {
        public node sol, sag;
        public int deger;
        public node(int deger)
        {
            this.sol = null;
            this.sag = null;
            this.deger = deger;
        }
    }
    public enum order
    {
        preorder, postorder, inorder
    }
   
   
    public class BST
    {
        public node root { get; internal set; }
        int sayac;
        int Yedek;
        public BST()
        {
            this.root = null;
            this.sayac = 0;
        }
      
        public bool ekle(int deger) // BEYZA
        {
            var gezici = new node(deger);// yeni bir node oluşturuyoruz. 
            var gezici2 = this.root; //  root nodunu gecici bir değişkene atıyoruz.
            node gezici3 = null; // tekrar boş bir node oluşturuyoruz.
            if (this.root == null) // eğer root node null ise
            {
                this.root = gezici; // root noduna yeni oluşturduğumuz nodu atıyoruz. (gezici)
            }
            else
            { // değil ise aşağıdaki kodlar çalışacak
                while (gezici2 != null) //gezici2 nodu null oluncaya kadar while döngümüz sürekli dönüyor
                {
                    gezici3 = gezici2; // gezici2 nodunu gezici3 noduna atıyoruz.
                    if (deger > gezici2.deger) // eklediğimiz değer gezici2.deger degerinden büyükse 
                        gezici2 = gezici2.sag; // gezici2 noduna gezici.sag nodunu atıyoruz.
                    else if (deger < gezici2.deger) // eklediğimiz deger gezici2.deger değerinden küçükse
                        gezici2 = gezici2.sol; //gezici2 noduna gezici2.sol nodunu atıyoruz.
                    else // iki şartada uymazsa fonksyonu kırıyoruz.
                    {
                        return false;
                    }
                }
                if (deger > gezici3.deger)// ekledeğimiz değer gezici.deger değerinden büyükse 
                {
                    gezici3.sag = gezici; // gezici3.sag nonuda gezici nodunu atıyoruz.
                }
                else
                {
                    gezici3.sol = gezici; // değilse gezici3.sol noduna gezici nodunu atıyoruz
                }
            }
            this.sayac++; // sayacı bir artırıyoruz // node sayısını bilmek icin
            return true;
        }
        public List<string> elemanekle(order d) // YUSUF
        {
            List<string> L = new List<string>();
            switch (d)
            {
                case order.preorder:
                    preorder(this.root, ref L);
                    break;
                case order.postorder:
                    postorder(this.root, ref L);
                    break;
                case order.inorder:
                    inorder(this.root, ref L);
                    break;
                default:
                    break;
            }
            return L;
        }
        bool inorder(node root, ref List<string> degerler) //YUSUF
        {
            if (this.sayac == 0)
                return false;
            if (root == null)
                return false;
            this.inorder(root.sol, ref degerler);
            degerler.Add(root.deger.ToString());
            this.inorder(root.sag, ref degerler);
            return true;
        }
        bool preorder(node root, ref List<string> degerler) // YUSUF
        {
            
            if (this.sayac == 0)
                return false;
            if (root == null)
                return false;
            degerler.Add(root.deger.ToString());
            this.inorder(root.sol, ref degerler);
            this.inorder(root.sag, ref degerler);
            return true;
        }
        bool postorder(node root, ref List<string> degerler) //YUSUF
        {
            if (this.sayac == 0)
                return false;
            if (root == null)
                return false;
            this.inorder(root.sol, ref degerler);
            this.inorder(root.sag, ref degerler);
            degerler.Add(root.deger.ToString());
            return true;
        }
        public bool Sil(int deger) // MUSTAFA
        {
            bool bul = false;
            node ebeveyn = null;
            node gezici = this.root; //root nodunu geçici bir değişkene atıyoruz
        
            bool Sagcocuk = false;
            //düğüm bulunursa devam et
            while (!bul && gezici != null)
            {
                //değer gezici değerinden küçükse sola git
                if (deger < gezici.deger)
                {
                    ebeveyn = gezici; // geziciyi ebeveyne  atıyoruz
                    gezici = gezici.sol; // gezicinin solunuda geziciye atıyoruz
                    Sagcocuk = false;
                    //değer gezici değerinden büyükse saga git
                }
                else if (deger > gezici.deger)
                {
                    ebeveyn = gezici;
                    gezici = gezici.sag;
                    Sagcocuk = true;
                    //değerler eşitse bulundu
                }
                else
                {
                    bul = true;
                }
            }

            if (!bul) // sayı bulunamadıysa fonksiyonu kırıyor
            {
                return false;
            }

            if (bul) // sayı varsa
            {
                if ((gezici.sol == null) && (gezici.sag == null))// gezici sağ ve sol boş ise
                {
                    if (ebeveyn == null)//ebeveyn boş ise
                    {
                        var cur = this.root;
                        {
                            this.root = null; // root null yapılıyor.
                        }
                    }
                    else // ebeveyn dolu ise
                    {
                        node cur;
                       
                        if (Sagcocuk) //sag cocuğa gidiliyor. 
                        {
                            cur = ebeveyn.sag;
                           
                            ebeveyn.sag = null; // ebeveynin sagı null yapılıyor.
                        }
                        else // sol cocuga gidiliyor 
                        {
                            cur = ebeveyn.sol;
                        
                            ebeveyn.sol = null; // ebeveynin sol cocugu null yapılıyor (siliniyor.)
                        }
                    }
                    this.sayac--; // sayacı bir azaltıyoruz.
                    return true;
                }

                //

                else if (gezici.sol == null)  // gezicinin sağı dolu solu boş ise 
                {
                   
                    if (ebeveyn == null)  // ebeveyn null ise
                    {
                        var cur = gezici.sag;
                        this.root = gezici.sag; //gezicinin sağı roota atanıyor.
                    }
                    else // ebeveyn dolu ise
                    {
                       
                        if (Sagcocuk) // sag cocuğa gidiliyor
                        {
                            var cur = gezici.sag;
                            ebeveyn.sag = gezici.sag; // gezinin sağı ebeveynin sağına atanıyor
                        }
                        else // sag cocuk 0 sol cocuk 1
                        {
                            var cur = gezici.sag;
                            ebeveyn.sol = gezici.sag;
                        }
                    }
                    this.sayac--;
                    return true;
                }

                //

                else if (gezici.sag == null) // gezicinin sağı boş solu dolu ise
                {
                    if (ebeveyn == null)  // ebeveyn boş ise 
                    {
                        var cur = gezici.sol;
                        this.root = gezici.sol; // gezici sol roota atanıyor.
                    }
                    else
                    {
                        
                        if (Sagcocuk) // sag cocuk kontrol ediliyor 
                        {
                            var cur = gezici.sol;
                            ebeveyn.sag = gezici.sol; // gezicinin solu ebeveynin sağına atanıyor.
                        }
                        else // sol cocuk kontrol ediliyor.
                        {
                            var cur = gezici.sol; 
                            ebeveyn.sol = gezici.sol; // gezicinin solu ebeveynin soluna atanıyor.
                        }
                    }
                    this.sayac--; // eleman silindiği için sayac bir azaltılıyor.
                    return true;
                }

                else // if((gezici->sol!=NULL)&&(gezici->sag!=NULL))   // gezicinin sağı ve solu dolu ise 
                {
                    var maxsol = this.maxdeger(gezici.sol).deger; // gezicinin solu maksimum değerini yedeğe alır siler.
                    this.Yedek = maxsol; // sol agacın en byük değerini buluyor.
                    this.Sil(maxsol);
                    gezici.deger = this.Yedek; // yedektekini gezicinin yeni değerine atıyor.(maksimum?
                }
                return true;
            }
            return false;
        }
        public node maxdeger(node where) // RECEP
        {
            var gezici = where;
            while (gezici != null) // gezici nodu null oluncaya kadar dönüyoruz ve en sağdaki nodu buluyoruz.
            {
                if (gezici.sag == null)
                {
                    return gezici;
                }
                else
                    gezici = gezici.sag;
            }
            return null;
        }
        public node bul(int deger) // SUDE
        {
            node gezici2 = this.root; // gezici2 noduna root nodunu atıyoruz.
            while (gezici2 != null) // gezici2 nodu null oluncaya kadar donuyoruz.
            {
                if (deger > gezici2.deger) // fonksiyona girdiğimiz deger ile gezici2.deger degerini karşılaştırıyoruz eğer girdiğimiz deger büyükse gezici2 noduna yine gezici2 nodunun sag nodunu atıyoryuz.
                    gezici2 = gezici2.sag;
                else if (deger < gezici2.deger) // fonksiyona girdiğimiz deger, gezici2.deger den küçükse gezici2 noduna gezici.sol nodunu atıyoruz.
                    gezici2 = gezici2.sol;
                else
                    return gezici2;
            }
            return null;
        }

        public void Temizle() // SUDE
        {
            // tüm node leri temizleyip sayacı sıfırlıyoruz.
            // ve root nodumuza null atıyoruz.
            this.temizle(this.root);
            this.root = null;
            this.sayac = 0;
        }
        void temizle(node root) // SUDE
        {
            if (root != null) // ROOT boş değilse 
            {
                this.temizle(root.sol);
                this.temizle(root.sag);
                root = null;
                this.sayac--; 
            }
        }
    }
}
