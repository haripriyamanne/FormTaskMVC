USE [TestEmp]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 07-07-2021 10.14.37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[PhoneNumber] [bigint] NULL,
	[Gender] [varchar](50) NULL,
	[CompanyName] [varchar](50) NULL,
	[CompanyType] [varchar](50) NULL,
	[CompanyLimited] [varchar](50) NULL,
	[CompanyWebsite] [varchar](50) NULL,
	[Busineess] [varchar](50) NULL,
	[Benifits] [varchar](50) NULL,
	[ListProducts] [varchar](50) NULL,
	[TrustElements] [varchar](50) NULL,
	[ImportantAreas] [varchar](50) NULL,
	[WebsiteExample] [nchar](10) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


