USE [master]
GO
/****** Object:  Database [GSB_gesAMM]    Script Date: 05/01/2023 17:22:15 ******/
CREATE DATABASE [GSB_gesAMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GSB_gesAMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GSB_gesAMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GSB_gesAMM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GSB_gesAMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ARITHABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GSB_gesAMM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET  MULTI_USER 
GO
ALTER DATABASE [GSB_gesAMM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GSB_gesAMM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GSB_gesAMM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GSB_gesAMM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GSB_gesAMM] SET QUERY_STORE = OFF
GO
USE [GSB_gesAMM]
GO
/****** Object:  Table [dbo].[ARCHIVE_ETAPENORME]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARCHIVE_ETAPENORME](
	[idModif] [int] IDENTITY(1,1) NOT NULL,
	[dateModif] [datetime] NOT NULL,
	[etpLibelle] [varchar](50) NOT NULL,
	[etpNorme] [varchar](20) NOT NULL,
	[etpDateNorme] [datetime] NOT NULL,
 CONSTRAINT [PK7] PRIMARY KEY CLUSTERED 
(
	[idModif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DESISION]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DESISION](
	[DCS_LIBELLE] [varchar](15) NOT NULL,
	[DCS_ID] [int] NOT NULL,
 CONSTRAINT [PK3] PRIMARY KEY CLUSTERED 
(
	[DCS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DROIT]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DROIT](
	[id] [int] NOT NULL,
	[libelle] [varchar](35) NULL,
 CONSTRAINT [PK1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETAPE]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETAPE](
	[ETP_NUM] [int] NOT NULL,
	[ETP_LIBELLE] [varchar](50) NOT NULL,
	[ETP_NORME] [varchar](20) NULL,
	[ETP_DATE_NORME] [date] NULL,
 CONSTRAINT [PK4] PRIMARY KEY CLUSTERED 
(
	[ETP_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FAMILLE]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAMILLE](
	[FAM_CODE] [nvarchar](255) NULL,
	[FAM_LIBELLE] [nvarchar](255) NULL,
	[nbMedAutorisé] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMENT]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMENT](
	[MED_DEPOTLEGAL] [varchar](100) NOT NULL,
	[MED_NOMCOMMERCIAL] [varchar](100) NOT NULL,
	[FAM_CODE] [varchar](6) NOT NULL,
	[MED_COMPOSITION] [varchar](255) NOT NULL,
	[MED_EFFETS] [text] NOT NULL,
	[MED_CONTREINDIC] [text] NOT NULL,
	[MED_PRIXECHANTILLON] [money] NULL,
 CONSTRAINT [PK6] PRIMARY KEY CLUSTERED 
(
	[MED_DEPOTLEGAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UTILISATEURS]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UTILISATEURS](
	[UTI_ID] [int] NOT NULL,
	[UTI_NOM_UTILISATEUR] [varchar](15) NOT NULL,
	[UTI_MDP_UTILISATEUR] [varchar](50) NOT NULL,
	[UTI_DRO_ID] [int] NOT NULL,
 CONSTRAINT [PK2] PRIMARY KEY CLUSTERED 
(
	[UTI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WORKFLOW]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORKFLOW](
	[numEtape] [int] NOT NULL,
	[MED_DL] [varchar](100) NOT NULL,
	[idDecision] [int] NULL,
	[dateDecision] [date] NULL,
 CONSTRAINT [PK5] PRIMARY KEY CLUSTERED 
(
	[numEtape] ASC,
	[MED_DL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UTILISATEURS]  WITH CHECK ADD  CONSTRAINT [FK1] FOREIGN KEY([UTI_DRO_ID])
REFERENCES [dbo].[DROIT] ([id])
GO
ALTER TABLE [dbo].[UTILISATEURS] CHECK CONSTRAINT [FK1]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [FK2] FOREIGN KEY([idDecision])
REFERENCES [dbo].[DESISION] ([DCS_ID])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [FK2]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [FK3] FOREIGN KEY([numEtape])
REFERENCES [dbo].[ETAPE] ([ETP_NUM])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [FK3]
GO
/****** Object:  StoredProcedure [dbo].[prc_ajout_medicament]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_ajout_medicament] (@depotlegale as varchar(100), @nomcommercial as varchar(100), @famcode as varchar(6), @composition as varchar(255), @effets as text, @contreindication as text, @prixechantillon as money)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO MEDICAMENT
	VALUES(@depotlegale,
	@nomcommercial,
	@famcode,
	@composition,
	@effets,
	@contreindication,
	@prixechantillon)
	
END
GO
/****** Object:  StoredProcedure [dbo].[prc_getDesisions]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_getDesisions]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DCS_ID, DCS_LIBELLE 
	FROM [dbo].[DESISION]
END
GO
/****** Object:  StoredProcedure [dbo].[prc_getEtapes]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_getEtapes]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ETP_NUM, ETP_LIBELLE, ETP_NORME, ETP_DATE_NORME
	FROM [dbo].[ETAPE]
END
GO
/****** Object:  StoredProcedure [dbo].[prc_getFamilles]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_getFamilles]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT FAM_CODE, FAM_LIBELLE, nbMedAutorisé
	FROM [dbo].[FAMILLE]

END
GO
/****** Object:  StoredProcedure [dbo].[prc_getHistoModifEtpNormee]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_getHistoModifEtpNormee]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF OBJECT_ID('ARCHIVE_ETAPENORME') IS NOT NULL
	BEGIN
		SELECT idModif, dateModif, etpLibelle, etpNorme, etpDateNorme
		FROM [dbo].[ARCHIVE_ETAPENORME]
	END
END
GO
/****** Object:  StoredProcedure [dbo].[prc_getMedicaments]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_getMedicaments]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, FAM_CODE, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_PRIXECHANTILLON
	FROM [dbo].[MEDICAMENT]

END
GO
/****** Object:  StoredProcedure [dbo].[prc_getUtilisateurs]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_getUtilisateurs]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UTI_NOM_UTILISATEUR, UTI_MDP_UTILISATEUR, UTI_DRO_ID 
	FROM [dbo].[UTILISATEURS]
END
GO
/****** Object:  StoredProcedure [dbo].[prc_getWorkflows]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_getWorkflows]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idDecision, numEtape, dateDecision, MED_DL
	FROM [dbo].[WORKFLOW]
END
GO
/****** Object:  StoredProcedure [dbo].[prc_maj_etapenormee]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_maj_etapenormee]
@numEtape INTEGER,
@etpNorme VARCHAR(20),
@etpNormeDate DATETIME
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF (@etpNorme <> (SELECT ETP_NORME FROM [dbo].[ETAPE] WHERE ETP_NUM = @numEtape)) AND (@etpNormeDate <> (SELECT ETP_DATE_NORME FROM [dbo].[ETAPE] WHERE ETP_NUM = @numEtape))
	BEGIN
		UPDATE [dbo].[ETAPE]
		SET ETP_NORME = @etpNorme,
		ETP_DATE_NORME = @etpNormeDate
		WHERE ETP_NUM = @numEtape
		
		RETURN
	END

	IF @etpNorme <> (SELECT ETP_NORME FROM [dbo].[ETAPE] WHERE ETP_NUM = @numEtape)
	BEGIN
		UPDATE [dbo].[ETAPE]
		SET ETP_NORME = @etpNorme
		WHERE ETP_NUM = @numEtape
		
		RETURN
	END

	IF @etpNormeDate <> (SELECT ETP_DATE_NORME FROM [dbo].[ETAPE] WHERE ETP_NUM = @numEtape)
	BEGIN
		UPDATE [dbo].[ETAPE]
		SET ETP_DATE_NORME = @etpNormeDate
		WHERE ETP_NUM = @numEtape

		RETURN
	END
END
GO
/****** Object:  StoredProcedure [dbo].[prc_setDecisionEtape]    Script Date: 05/01/2023 17:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_setDecisionEtape] 
	@numEtape integer, 
	@medDL varchar (100),
	@idDec integer,
	@dateDec date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[WORKFLOW]
	SET idDecision = @idDec,
	dateDecision = @dateDec
	WHERE numEtape = @numEtape
	AND MED_DL = @medDL
END
GO
USE [master]
GO
ALTER DATABASE [GSB_gesAMM] SET  READ_WRITE 
GO
