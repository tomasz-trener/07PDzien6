using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            Zawodnik[] zawodnicy=  db.Zawodnik.ToArray();

            Zawodnik[] zawodnicy2 = db.Zawodnik.Where(x => x.kraj == "pol").ToArray();

            foreach (var z in zawodnicy2)
                Console.WriteLine(z.imie + " " + z.nazwisko);


            // CRUD 

            // dodawanie rekordów 

            Zawodnik nowy = new Zawodnik()
            {
                imie = "janXXX",
                nazwisko = "kowalski",
                kraj = "pol"
            };

            db.Zawodnik.InsertOnSubmit(nowy);
            db.SubmitChanges();

            // edycja rekordów 
            // 1)najpierw trzeba pobrać tego zawodnika, którego edytujemy
            //2) a potem zmienić jego elementy 
            //3) zapisać zmiany 

            Zawodnik doEdycji = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == 2);
            doEdycji.imie = "Lukasz";
            db.SubmitChanges();


            Zawodnik[] doUsuniecia = db.Zawodnik.Where(x => x.nazwisko == "Kowalski").ToArray();
            db.Zawodnik.DeleteAllOnSubmit(doUsuniecia);
            db.SubmitChanges();



            Console.ReadLine();

            // 3 sposoby komunikacji z baza danych

            //1) polecenia SQL -> pośrednie rozwiąznie 
            //2) mapowanie ORM -> najwygodniejsze ale najwolniejsze 
            //3) procedury wbudowane  -> najtrudniejsze ale najszybsze 

        }

    }
}
