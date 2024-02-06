using ConsoleApp12.Contexts;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using DebtorDb context = new DebtorDb();
            //2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag
            //var datas = context.Debtors.Where(d => d.Email.Contains("rhyta.com") || d.Email.Contains("dayrep.com")).ToList();


            //3) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag
            //var datas = context.Debtors.Where(d => (DateTime.Now.Year - d.BirthDay.Year) > 26 && (DateTime.Now.Year - d.BirthDay.Year) < 36).ToList();


            //4) Borcu 5000 - den cox olmayan borclularic cixartmag
            //var datas = context.Debtors.Where(d => d.Debt < 5000).ToList();


            //5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq
            //var datas = context.Debtors.AsEnumerable().Where(d => d.FullName.Length > 18 && d.Phone.Count(n => n == '7') > 2).ToList();


            //7) Qishda anadan olan borclulari cixardmaq
            //var arr = new List<int>() { 12, 01, 02 };
            //var datas = context.Debtors.Where(d => arr.Contains(d.BirthDay.Month)).ToList();


            //8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek
            //var avarage = context.Debtors.Average(a => a.Debt);
            //var datas = context.Debtors.Where(d => d.Debt > avarage).OrderBy(d => d.FullName).OrderByDescending(d => d.Debt).ToList();


            //9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq
            //var datas = context.Debtors.Where(d => !d.Phone.Contains("8"))
            //    .ToList()
            //    .Select(d => new
            //    {
            //        Fullname= d.FullName.Substring(d.FullName.IndexOf(" "), (d.FullName.Length - (d.FullName.IndexOf(" ") + 1))),
            //        age = DateTime.Now.Year - d.BirthDay.Year,
            //        amount = d.Debt
            //    }).ToList();



            //11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek
            //var datas = context.Debtors.AsEnumerable()
            //    .Where(d => d.FullName.GroupBy(c => c).Any(g => g.Count() >= 4)).OrderBy(d=>d.FullName).ToList();



            //13)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq
            //var groups = context.Debtors
            //                .GroupBy(e => e.BirthDay)
            //                .Select(group => new
            //                {
            //                    year = group.Key.Year,
            //                    Headcount = group.Count()
            //                })
            //                .OrderByDescending(dc => dc.Headcount)
            //                .FirstOrDefault();


            //14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq
            //var datas = context.Debtors
            //                .OrderByDescending(dc => dc.Debt)
            //                .Take(5);


            //15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq
            //var datas = context.Debtors.Sum(d => d.Debt);


            //16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq
            //var datas = context.Debtors.Where(d => d.BirthDay.Year > 1939 && d.BirthDay.Year < 1945).ToList();


            //18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq
            //var datas = context.Debtors.AsEnumerable()
            //.Where(d => d.Phone.GroupBy(c => c).All(g => g.Count() == 1)).ToList();


            //19)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq
            //var user = context.Debtors.Where(d => DateTime.Now.Month - d.BirthDay.Month * 500 < d.Debt).ToList();


            //20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq
            //var arr = new List<string>() { "s", "m", "i", "l", "e" };
            //var datas = context.Debtors.Where(d => arr.All(a => d.FullName.Contains(a))).ToList();

        }
    }
}