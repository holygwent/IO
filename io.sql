CREATE TABLE Administrator(
	[Login] [nvarchar](30) NOT NULL,
	[Haslo] [nvarchar](30) NOT NULL
);
CREATE TABLE Klienci(
	[IDKlienta] [int]  NOT NULL,
	[Imie] [nvarchar](30) NOT NULL,
	[Nazwisko] [nvarchar](30) NOT NULL,
	[Adres] [nvarchar](60) NOT NULL,
	[Miasto] [nvarchar](20) NOT NULL,
	[KodPocztowy] [nvarchar](10) NOT NULL,
	[Kraj] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](40) NOT NULL,
	[Telefon] [nvarchar](24) NOT NULL,
	[IDZajecia] [int] NOT NULL,
	[DataDoladowania] [datetime] NOT NULL,
	[Karnet] [int] NOT NULL,
	[DataWygasniecia] [datetime] NULL,
	PRIMARY KEY(IDKlienta)
	);
CREATE TABLE Pracownicy(
	[IDPracownik] [int] NOT NULL,
	[Imie] [nvarchar](30) NOT NULL,
	[Nazwisko] [nvarchar](30) NOT NULL,
	[Adres] [nvarchar](60) NOT NULL,
	[Miasto] [nvarchar](20) NOT NULL,
	[KodPocztowy] [nvarchar](10) NOT NULL,
	[Kraj] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](40) NOT NULL,
	[Telefon] [nvarchar](24) NOT NULL,
	[Pesel] [nvarchar](11) NOT NULL,
	[DataUrodzenia] [datetime] NOT NULL,
	[DataZatrudnienia] [datetime] NOT NULL,
	[NrBankowy] [nvarchar](40) NOT NULL,
	PRIMARY KEY(IDPracownik)
	);
CREATE TABLE Trenerzy(
	[IDTrener] [int] NOT NULL,
	[Imie] [nvarchar](30) NOT NULL,
	[Nazwisko] [nvarchar](30) NOT  NULL,
	[Adres] [nvarchar](60) NOT NULL,
	[Miasto] [nvarchar](20) NOT NULL,
	[KodPocztowy] [nvarchar](10) NOT NULL,
	[Kraj] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](40) NOT NULL,
	[Telefon] [nvarchar](24) NOT  NULL,
	[Pesel] [nvarchar](11) NOT NULL,
	[DataUrodzenia] [datetime] NOT NULL,
	[DataZatrudnienia] [datetime] NOT NULL,
	[IDZajecia] [int] NOT NULL,
	[NrBankowy] [nvarchar](40) NOT NULL,
	PRIMARY KEY(IDTrener)
	);
CREATE TABLE Zajecia(
	[IDZajecia] [int] NOT NULL,
	[Nazwa] [nvarchar](30) NOT NULL,
	[Godzina] [time](7) NOT NULL,
	PRIMARY KEY(IDZajecia)
	); 
