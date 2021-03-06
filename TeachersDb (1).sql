USE [TestProject]
GO
/****** Object:  Table [dbo].[Pupil]    Script Date: 7/13/2022 21:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pupil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Grade] [int] NOT NULL,
 CONSTRAINT [PK_Pupil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 7/13/2022 21:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Subject] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherPupils]    Script Date: 7/13/2022 21:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherPupils](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Teacher_Id] [int] NOT NULL,
	[Pupil_Id] [int] NOT NULL,
 CONSTRAINT [PK_TeacherPupils] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TeacherPupils]  WITH CHECK ADD FOREIGN KEY([Pupil_Id])
REFERENCES [dbo].[Pupil] ([Id])
GO
ALTER TABLE [dbo].[TeacherPupils]  WITH CHECK ADD FOREIGN KEY([Teacher_Id])
REFERENCES [dbo].[Teacher] ([Id])
GO
ALTER TABLE [dbo].[TeacherPupils]  WITH CHECK ADD  CONSTRAINT [FK_TeacherPupils_TeacherPupils] FOREIGN KEY([Id])
REFERENCES [dbo].[TeacherPupils] ([Id])
GO
ALTER TABLE [dbo].[TeacherPupils] CHECK CONSTRAINT [FK_TeacherPupils_TeacherPupils]
GO
ALTER TABLE [dbo].[TeacherPupils]  WITH CHECK ADD  CONSTRAINT [FK_TeacherPupils_TeacherPupils1] FOREIGN KEY([Id])
REFERENCES [dbo].[TeacherPupils] ([Id])
GO
ALTER TABLE [dbo].[TeacherPupils] CHECK CONSTRAINT [FK_TeacherPupils_TeacherPupils1]
GO

select t.Name,t.Surname  from TeacherPupils tp
inner join Pupil p on p.Id=tp.Pupil_Id
inner join Teacher t on t.id=tp.Teacher_Id
where p.Name='Giorgi'

