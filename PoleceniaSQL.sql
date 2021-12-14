

select * from zawodnicy 
where kraj = 'pol'


select * from zawodnicy 
where kraj = 'pol' or kraj = 'ger'


select * from zawodnicy 
where kraj = 'pol' and wzrost > 170

select * from zawodnicy
where id_zawodnika=4


select * from zawodnicy
where wzrost>waga*2

select * from zawodnicy
where LEN(imie)=4

select * from zawodnicy
where left(imie,1)=LEFT(nazwisko,1)

select * from zawodnicy
where id_trenera is null


select imie + ' ' + nazwisko from zawodnicy
order by waga/POWER(wzrost/100.0,2)


select imie, nazwisko 
from zawodnicy


select 
UPPER(left(imie,1)) + 
lower(right(imie,LEN(imie)-1)) + 
' ' + 
UPPER(left(nazwisko,1)) + 
lower(right(nazwisko,LEN(nazwisko)-1)) + 

+ ' (' + kraj + ')'
from zawodnicy


select imie + ' ' + nazwisko
from zawodnicy
where kraj = 'pol'
order by wzrost



select distinct kraj from zawodnicy


select kraj, avg(wzrost)
from zawodnicy
group by kraj


