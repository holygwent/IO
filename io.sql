CREATE TABLE Administrator(
	[Login] [nvarchar](30)  NULL,
	[Haslo] [nvarchar](30)  NULL
);
CREATE TABLE Klienci(
	[IDKlienta] [int]  NOT NULL,
	[Imie] [nvarchar](30)  NULL,
	[Nazwisko] [nvarchar](30)  NULL,
	[Adres] [nvarchar](60)  NULL,
	[Miasto] [nvarchar](20)  NULL,
	[KodPocztowy] [nvarchar](10)  NULL,
	[Kraj] [nvarchar](20)  NULL,
	[Email] [nvarchar](40)  NULL,
	[Telefon] [nvarchar](24)  NULL,
	[IDZajecia] [int]  NULL,
	[DataDoladowania] [datetime]  NULL,
	[Karnet] [int] NULL,
	[DataWygasniecia] [datetime]  NULL,
	PRIMARY KEY(IDKlienta)
	);
CREATE TABLE Pracownicy(
	[IDPracownik] [int] NOT NULL,
	[Imie] [nvarchar](30)  NULL,
	[Nazwisko] [nvarchar](30)  NULL,
	[Adres] [nvarchar](60)  NULL,
	[Miasto] [nvarchar](20)  NULL,
	[KodPocztowy] [nvarchar](10)  NULL,
	[Kraj] [nvarchar](20)  NULL,
	[Email] [nvarchar](40)  NULL,
	[Telefon] [nvarchar](24)  NULL,
	[Pesel] [nvarchar](11)  NULL,
	[DataUrodzenia] [datetime]  NULL,
	[DataZatrudnienia] [datetime]  NULL,
	[NrBankowy] [nvarchar](40)  NULL,
	PRIMARY KEY(IDPracownik)
	);

