### SqlUpiti
SqlUpiti je Windows Forms Application koja omogućuje upis izvođenje sql select naredbi.

#### Opis forme
Forma sadrži TextBox za unos upita, Button na čiji klik se odvija spajanje na bazu i izvršavanje upita,
DataGridView koji služi za prikaz rezultata upita i dvije labele koje služe za identificranje TextBoxa-a 
i DataGridView-a.

DataGriedView i pripadajuća labela su vidljivi jedino ako je uspješno izvršen upit nad bazom.
Ukoliko je TextBox za unos upita prazan ili je upit nepravilno napisan, 
pritiskom na Button pokazuje se odgovarajući MessageBox s porukom o grešci.
