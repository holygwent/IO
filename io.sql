CREATE TABLE Administrator(
	[Login] [nvarchar](30) NOT NULL,
	[Haslo] [nvarchar](30) NOT NULL
);
CREATE TABLE [dbo].[Klient] (
    [IdKlienta]       INT            IDENTITY (1, 1) NOT NULL,
    [Imie]            NVARCHAR (50)  NOT NULL,
    [Nazwisko]        NVARCHAR (50)  NOT NULL,
    [Adres]           NVARCHAR (100) NOT NULL,
    [Miasto]          NVARCHAR (50)  NOT NULL,
    [KodPocztowy]     NVARCHAR (10)  NOT NULL,
    [Kraj]            NVARCHAR (50)  NOT NULL,
    [Telefon]         NVARCHAR (30)  NOT NULL,
    [Email]           NVARCHAR (100) NOT NULL,
    [DataDoladowania] DATE           NOT NULL,
    [Karnet]          INT            NOT NULL,
    [DataWygasniecia] DATE           NULL,
    [IdZajecia]       INT            NOT NULL,
    [Login]           NVARCHAR (50)  NOT NULL,
    [Haslo]           NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([IdKlienta] ASC),
    CONSTRAINT [FK_Klient_ToKarnet] FOREIGN KEY ([Karnet]) REFERENCES [dbo].[Karnet] ([Id]),
    CONSTRAINT [FK_Klient_ToZajecia] FOREIGN KEY ([IdZajecia]) REFERENCES [dbo].[Zajecia] ([IdZajecia])
);
CREATE TABLE [dbo].[Pracownicy] (
    [IdPracownika]     INT            IDENTITY (1, 1) NOT NULL,
    [Imie]             NVARCHAR (50)  NOT NULL,
    [Nazwisko]         NVARCHAR (50)  NOT NULL,
    [Adres]            NVARCHAR (100) NOT NULL,
    [Miasto]           NVARCHAR (50)  NOT NULL,
    [KodPocztowy]      NVARCHAR (30)  NOT NULL,
    [Kraj]             NVARCHAR (50)  NOT NULL,
    [Email]            NVARCHAR (100) NOT NULL,
    [Telefon]          NVARCHAR (30)  NOT NULL,
    [Pesel]            NVARCHAR (11)  NOT NULL,
    [DataUrodzenia]    DATE           NOT NULL,
    [DataZatrudnienia] DATE           NOT NULL,
    [NrBankowy]        NVARCHAR (50)  NOT NULL,
    [Login]            NVARCHAR (50)  NOT NULL,
    [Haslo]            NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([IdPracownika] ASC)
);

CREATE TABLE [dbo].[Trener] (
    [IdTrener]         INT            IDENTITY (1, 1) NOT NULL,
    [Imie]             NVARCHAR (50)  NOT NULL,
    [Nazwisko]         NVARCHAR (50)  NOT NULL,
    [Adres]            NVARCHAR (100) NOT NULL,
    [Miasto]           NVARCHAR (50)  NOT NULL,
    [KodPocztowy]      NVARCHAR (10)  NOT NULL,
    [Kraj]             NVARCHAR (50)  NOT NULL,
    [Email]            NVARCHAR (100) NOT NULL,
    [Telefon]          NVARCHAR (30)  NOT NULL,
    [Pesel]            NVARCHAR (11)  NOT NULL,
    [DataUrodzenia]    DATE           NOT NULL,
    [DataZatrudnienia] DATE           NOT NULL,
    [IdZajecia]        INT            NOT NULL,
    [NrBankowy]        NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([IdTrener] ASC),
    CONSTRAINT [FK_Trener_ToZajecia] FOREIGN KEY ([IdZajecia]) REFERENCES [dbo].[Zajecia] ([IdZajecia])
);

CREATE TABLE [dbo].[Zajecia] (
    [IdZajecia] INT           IDENTITY (1, 1) NOT NULL,
    [Nazwa]     NVARCHAR (50) NOT NULL,
    [Godzina]   TIME (7)      NOT NULL,
    PRIMARY KEY CLUSTERED ([IdZajecia] ASC)
);


CREATE TABLE [dbo].[Karnet] (
    [Id]    INT NOT NULL,
    [Dni]   INT NOT NULL,
    [Koszt] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


