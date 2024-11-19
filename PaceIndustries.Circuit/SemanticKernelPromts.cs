namespace PaceIndustries.Circuit
{
    public static class SemanticKernelPromts
    {
        public const string LLMPrompt = @"
        Check the SQL database structure.
        You have to convert a natural language query into a T-SQL query based on database structure.
        Use only accurate and existing field and table names from the database structure.
        The response should consist of a raw SQL query, without formatting ```sql and other characters.
		Each response should be based only on database structure and contains only a raw SQL query.
		You are strictly prohibited from generating any requests to insert, create, add, update, or delete data! You may only generate read requests!
        ";

        public const string DbSchema = @"/****** Object:  Table [dbo].[APOpen]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[APOpen](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[VouchRefNum] [bigint] NOT NULL,
				[SupplierId] [varchar](10) NOT NULL,
				[Division] [int] NOT NULL,
				[CurrCode] [varchar](4) NOT NULL,
				[DueDate] [datetime] NOT NULL,
				[InvoiceDate] [datetime] NOT NULL,
				[SupplierInvNum] [varchar](30) NOT NULL,
				[GLDate] [datetime] NOT NULL,
				[GrossDollars] [decimal](15, 2) NOT NULL,
				[Termcode] [varchar](4) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Calendar]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Calendar](
				[Id] [int] IDENTITY(1,1) NOT NULL,
				[CalendarDate] [date] NOT NULL,
				[Year] [int] NOT NULL,
				[Month] [int] NOT NULL,
				[Day] [int] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[CompanyAddress]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[CompanyAddress](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[Address1] [varchar](45) NULL,
				[Address2] [varchar](45) NULL,
				[Address3] [varchar](45) NULL,
				[City] [varchar](25) NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CoName] [varchar](50) NULL,
				[Country] [varchar](25) NULL,
				[Email] [varchar](255) NULL,
				[FaxNumber] [varchar](20) NULL,
				[FederalId] [varchar](15) NULL,
				[PhoneNumber] [varchar](20) NULL,
				[State] [varchar](3) NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[WebSite] [varchar](256) NULL,
				[Zipcode] [varchar](10) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Contact]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Contact](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[ParentId] [bigint] NOT NULL,
				[ParentCompanyId] [varchar](4) NOT NULL,
				[ParentKey] [varchar](10) NOT NULL,
				[TableName] [varchar](20) NULL,
				[Contact] [varchar](50) NULL,
				[ContactPrty] [int] NOT NULL,
				[ContactType] [varchar](4) NULL,
				[FirstName] [varchar](25) NULL,
				[LastName] [varchar](25) NULL,
				[Email] [varchar](255) NULL,
				[Active] [bit] NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[CurrencyHistory]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[CurrencyHistory](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CurrCode] [varchar](4) NOT NULL,
				[FromDate] [datetime] NOT NULL,
				[ToDate] [datetime] NOT NULL,
				[Exchgrate] [decimal](16, 5) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Customer]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Customer](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CustomerId] [varchar](10) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CoName] [varchar](35) NOT NULL,
				[ParentCustomerId] [varchar](10) NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[Active] [bit] NOT NULL,
				[TermCode] [varchar](4) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
			 CONSTRAINT [con_uq_customer] UNIQUE NONCLUSTERED
			(
				[CustomerId] ASC,
				[CompanyId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[CUSTOMERX]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[CUSTOMERX](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[FLAGS] [varchar](256) NULL,
				[PARENTID] [bigint] NULL,
				[X_A00005] [varchar](15) NULL,
				[X_A00009] [varchar](15) NULL,
				[X_A00007] [varchar](15) NULL,
				[X_N00001] [decimal](20, 5) NULL,
				[X_N00002] [decimal](20, 5) NULL,
				[X_A00003] [varchar](15) NULL,
				[X_A00004] [varchar](15) NULL,
				[X_A00006] [varchar](15) NULL,
				[X_A00008] [varchar](15) NULL,
				[X_A00010] [varchar](15) NULL,
				[X_D00012] [date] NULL,
				[X_A00013] [varchar](15) NULL,
				[x_supplypass] [varchar](50) NULL,
				[x_supplyuserid] [varchar](50) NULL,
				[x_supplyweb] [varchar](50) NULL,
				[x_CSTier] [varchar](10) NULL,
				[x_AccountOwner] [varchar](100) NULL,
				[x_MarketStack] [varchar](35) NULL,
				[x_RebateFactorCustomer] [varchar](100) NULL,
				[x_SFID] [varchar](50) NULL,
				[x_TopCustomer] [varchar](50) NULL,
				[x_CERTIFICADOORIGEN] [varchar](50) NULL,
				[x_CFDI_USO] [varchar](50) NULL,
				[x_CLAVEDEPEDIMENTO] [varchar](50) NULL,
				[x_COLONIA_KEY] [varchar](50) NULL,
				[x_CUS_ACCOUNT] [varchar](50) NULL,
				[x_CUS_BANK_ID] [varchar](50) NULL,
				[x_CUS_BANK_NAME] [varchar](50) NULL,
				[x_CUSTNAME] [varchar](50) NULL,
				[x_DESTINATARIOCURP] [varchar](50) NULL,
				[x_DESTINATARIONUMREGIDTRIB] [varchar](50) NULL,
				[x_DESTINATARIORFC] [varchar](50) NULL,
				[x_DIRECCIONCODIGOPOSTAL] [varchar](50) NULL,
				[x_DIRECCIONCOLONIA] [varchar](50) NULL,
				[x_DIRECCIONESTADO] [varchar](50) NULL,
				[x_DIRECCIONLOCALIDAD] [varchar](50) NULL,
				[x_DIRECCIONMUNICIPIO] [varchar](50) NULL,
				[x_DIRECCIONPAIS] [varchar](50) NULL,
				[x_DIRECCIONREFERENCIA] [varchar](50) NULL,
				[x_EMISORCURP] [varchar](50) NULL,
				[x_ESTADO_KEY] [varchar](50) NULL,
				[x_FORMADEPAGO] [varchar](50) NULL,
				[x_INCOTERM_KEY] [varchar](50) NULL,
				[x_INVOICING_TYPE] [varchar](50) NULL,
				[x_LOCALIDAD_KEY] [varchar](50) NULL,
				[x_METODEPAGP] [varchar](50) NULL,
				[x_MUNICIPIO_KEY] [varchar](50) NULL,
				[x_NUMCERTIFICADOORIGEN] [varchar](50) NULL,
				[x_NUMCTAPAGO] [varchar](50) NULL,
				[x_PAIS_KEY] [varchar](50) NULL,
				[x_RECEPTORCURP] [varchar](50) NULL,
				[x_RECEPTORNUMREGIDTRIB] [varchar](50) NULL,
				[x_RESIDENCIAL_FISCAL] [varchar](50) NULL,
				[x_TIPOOPERACION] [varchar](50) NULL,
				[x_ZIP_KEY] [varchar](50) NULL,
				[x_ActivePlants] [varchar](200) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Employees]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Employees](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[Account] [varchar](15) NULL,
				[Active] [bit] NULL,
				[Address1] [varchar](45) NULL,
				[Address2] [varchar](45) NULL,
				[Address3] [varchar](45) NULL,
				[AltDateVacation] [date] NULL,
				[AutoClockOut] [varchar](5) NULL,
				[AutoClockVariance] [bigint] NULL,
				[Badge] [varchar](10) NULL,
				[Cellphone] [varchar](20) NULL,
				[City] [varchar](25) NULL,
				[ClockNumber] [int] NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CompanyPayrollId] [varchar](20) NULL,
				[CraftCode] [varchar](4) NULL,
				[DateHired] [date] NULL,
				[DateTerminated] [date] NULL,
				[Department] [int] NULL,
				[DiscplCounter] [bigint] NULL,
				[Email] [varchar](255) NULL,
				[ExpDate] [date] NULL,
				[Extension] [varchar](5) NULL,
				[FirstName] [varchar](50) NULL,
				[Foreman] [varchar](4) NULL,
				[HolidayEligible] [bit] NULL,
				[Homephone] [varchar](20) NULL,
				[IndirectOperation] [varchar](10) NULL,
				[LastName] [varchar](50) NULL,
				[LRScreenId] [varchar](25) NULL,
				[MiddleInit] [varchar](2) NULL,
				[MMHours] [decimal](10, 2) NULL,
				[MMSeq] [int] NULL,
				[Name] [varchar](35) NULL,
				[PayRate] [decimal](20, 5) NULL,
				[PayrollFeed] [varchar](1) NULL,
				[PayrollId] [varchar](15) NULL,
				[PointAccumDate] [date] NULL,
				[SFQUsersId] [varchar](12) NULL,
				[Shift] [varchar](1) NULL,
				[ShiftSchedule] [varchar](4) NULL,
				[State] [varchar](3) NULL,
				[Temp] [bit] NULL,
				[TempBadge] [varchar](10) NULL,
				[OdyUniqueId] [int] NOT NULL,
				[VacationAllowed] [int] NULL,
				[VacationEffDate] [date] NULL,
				[VacationOverride] [varchar](1) NULL,
				[VacCarryOver] [decimal](8, 2) NULL,
				[WorkPhone] [varchar](20) NULL,
				[Zipcode] [varchar](10) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ForecastDtl]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ForecastDtl](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[ProductId] [varchar](22) NOT NULL,
				[CustomerId] [varchar](10) NOT NULL,
				[Period] [int] NOT NULL,
				[Qty] [int] NOT NULL,
				[Amt] [decimal](15, 2) NOT NULL,
				[Wgt] [decimal](15, 2) NOT NULL,
				[Type] [varchar](4) NOT NULL,
				[Year] [int] NOT NULL,
				[Quarter] [int] NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Matltype]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Matltype](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[Account] [varchar](15) NULL,
				[Active] [bit] NULL,
				[AddBackInv] [bit] NULL,
				[BaseMType] [varchar](10) NULL,
				[CalcLossValue] [bit] NULL,
				[CalcOxidation] [bit] NULL,
				[ChangeDate] [date] NULL,
				[ChargeWeight] [decimal](20, 5) NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CurrentPrice] [decimal](10, 2) NULL,
				[Description] [varchar](50) NULL,
				[EstCost] [decimal](20, 5) NULL,
				[EstLoss] [decimal](7, 2) NULL,
				[EstSprue] [decimal](20, 5) NULL,
				[FrozenCost] [decimal](20, 5) NULL,
				[FrozenSprueCost] [decimal](20, 5) NULL,
				[FrozenStdLoss] [decimal](7, 2) NULL,
				[LastPrice] [decimal](20, 5) NULL,
				[MatlInvId] [varchar](22) NULL,
				[MetalRecovery] [bit] NULL,
				[MType] [varchar](10) NULL,
				[ProjStdCost] [decimal](20, 5) NULL,
				[ProjStdLoss] [decimal](7, 2) NULL,
				[ProjStdSprue] [decimal](20, 5) NULL,
				[ReturnAccount] [varchar](15) NULL,
				[ScrapVarAccount] [varchar](15) NULL,
				[SprueCost] [decimal](20, 5) NULL,
				[StdCost] [decimal](20, 5) NULL,
				[StdLoss] [decimal](7, 2) NULL,
				[OdyUniqueId] [int] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[MissingProduct]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[MissingProduct](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[ProductId] [varchar](22) NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Operations]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Operations](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[Account] [varchar](15) NULL,
				[Active] [bit] NULL,
				[ActMachFOVH] [decimal](20, 5) NULL,
				[ActMachLabr] [decimal](20, 5) NULL,
				[ActMachVOVH] [decimal](20, 5) NULL,
				[ActManFOVH] [decimal](20, 5) NULL,
				[ActManLabr] [decimal](20, 5) NULL,
				[ActManVOVH] [decimal](20, 5) NULL,
				[ActSetupFOVH] [decimal](20, 5) NULL,
				[ActSetupLabr] [decimal](20, 5) NULL,
				[ActSetupVOVH] [decimal](20, 5) NULL,
				[AllDays] [bit] NULL,
				[AutoAllocatedHours] [bit] NULL,
				[AutoAllocatedHoursProd] [bit] NULL,
				[AutoAllocProdMeth] [varchar](1) NULL,
				[AutoRecipeRelief] [bit] NULL,
				[BudgetCode] [varchar](5) NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CustomerSpecType] [varchar](4) NULL,
				[DateToUse] [varchar](1) NULL,
				[Department] [int] NULL,
				[Description] [varchar](50) NULL,
				[EnableFeedBack] [varchar](1) NULL,
				[EstMachFOVH] [decimal](20, 5) NULL,
				[EstMachLabr] [decimal](20, 5) NULL,
				[EstMachVOVH] [decimal](20, 5) NULL,
				[EstManFOVH] [decimal](20, 5) NULL,
				[EstManLabr] [decimal](20, 5) NULL,
				[EstManVOVH] [decimal](20, 5) NULL,
				[EstSetupFOVH] [decimal](20, 5) NULL,
				[EstSetupLabr] [decimal](20, 5) NULL,
				[EstSetupVOVH] [decimal](20, 5) NULL,
				[Fri] [bit] NULL,
				[FrozMachFOVH] [decimal](20, 5) NULL,
				[FrozMachLabr] [decimal](20, 5) NULL,
				[FrozMachVOVH] [decimal](20, 5) NULL,
				[FrozManFOVH] [decimal](20, 5) NULL,
				[FrozManLabr] [decimal](20, 5) NULL,
				[FrozManVOVH] [decimal](20, 5) NULL,
				[FrozSetupFOVH] [decimal](20, 5) NULL,
				[FrozSetupLabr] [decimal](20, 5) NULL,
				[FrozSetupVOVH] [decimal](20, 5) NULL,
				[IsHeatTreat] [bit] NULL,
				[LotFormulaCode] [varchar](20) NULL,
				[LotTracking] [bit] NULL,
				[MachineCapacity] [decimal](14, 2) NULL,
				[ManCapacity] [decimal](14, 2) NULL,
				[MetalCapacity] [bit] NULL,
				[Methinfi] [varchar](1) NULL,
				[MoldsCapacity] [bigint] NULL,
				[Mon] [bit] NULL,
				[Mstrwgts] [bit] NULL,
				[Operation] [varchar](10) NULL,
				[OperationType] [varchar](4) NULL,
				[OverridePercent] [decimal](9, 2) NULL,
				[OverrideQty] [bigint] NULL,
				[ProcessShtTmplate] [varchar](50) NULL,
				[ProcessSpecType] [varchar](4) NULL,
				[ProjMachFOVH] [decimal](20, 5) NULL,
				[ProjMachLabr] [decimal](20, 5) NULL,
				[ProjMachVOVH] [decimal](20, 5) NULL,
				[ProjManFOVH] [decimal](20, 5) NULL,
				[ProjManLabr] [decimal](20, 5) NULL,
				[ProjManVOVH] [decimal](20, 5) NULL,
				[ProjSetupFOVH] [decimal](20, 5) NULL,
				[ProjSetupLabr] [decimal](20, 5) NULL,
				[ProjSetupVOVH] [decimal](20, 5) NULL,
				[RateType] [varchar](1) NULL,
				[RecipeRelief] [varchar](1) NULL,
				[RelieveRecipe] [bit] NULL,
				[ReportSeries] [varchar](25) NULL,
				[Sat] [bit] NULL,
				[ScheduleBy] [varchar](1) NULL,
				[SchedulingGroup] [varchar](8) NULL,
				[SFQDisplayLabel] [varchar](20) NULL,
				[SFQProcessSeries] [varchar](35) NULL,
				[SFQShowinQV] [bit] NULL,
				[ShopCardTmplate] [varchar](50) NULL,
				[StartTime] [time](7) NULL,
				[StdMachFOVH] [decimal](20, 5) NULL,
				[StdMachLabr] [decimal](20, 5) NULL,
				[StdMachVOVH] [decimal](20, 5) NULL,
				[StdManFOVH] [decimal](20, 5) NULL,
				[StdManLabr] [decimal](20, 5) NULL,
				[StdManVOVH] [decimal](20, 5) NULL,
				[StdSetupFOVH] [decimal](20, 5) NULL,
				[StdSetupLabr] [decimal](20, 5) NULL,
				[StdSetupVOVH] [decimal](20, 5) NULL,
				[StopTime] [time](7) NULL,
				[Sun] [bit] NULL,
				[Thu] [bit] NULL,
				[ToolShopCardTmplate] [varchar](50) NULL,
				[Track] [bit] NULL,
				[Tue] [bit] NULL,
				[Type] [varchar](10) NULL,
				[OdyUniqueId] [int] NOT NULL,
				[Wed] [bit] NULL,
				[WgtCapacity] [decimal](14, 2) NULL,
				[WorkCenter] [varchar](3) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[OrderDate]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[OrderDate](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[ProductId] [varchar](22) NOT NULL,
				[CustomerId] [varchar](10) NOT NULL,
				[ShipTo] [varchar](10) NOT NULL,
				[OrderNumber] [int] NOT NULL,
				[OrderItem] [int] NOT NULL,
				[ReleaseNumber] [int] NOT NULL,
				[ReleaseDate] [datetime] NULL,
				[ReleaseQty] [int] NOT NULL,
				[RequestDate] [datetime] NULL,
				[RequestQty] [int] NOT NULL,
				[ShipQty] [int] NOT NULL,
				[ReturnQty] [int] NOT NULL,
				[Complete] [bit] NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[OrderHeader]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[OrderHeader](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CustomerId] [varchar](10) NOT NULL,
				[ShipTo] [varchar](10) NOT NULL,
				[OrderNumber] [int] NOT NULL,
				[OrderDate] [datetime] NOT NULL,
				[CustPo] [varchar](20) NOT NULL,
				[ClosedFlag] [bit] NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[OrderItem]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[OrderItem](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[OrderNumber] [int] NOT NULL,
				[OrderItem] [int] NULL,
				[ProductId] [varchar](22) NOT NULL,
				[Complete] [bit] NOT NULL,
				[SellPrice] [decimal](20, 5) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[paContact]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[paContact](
				[Id] [int] NOT NULL,
				[FirstName] [varchar](100) NULL,
				[LastName] [varchar](100) NULL,
				[Email] [varchar](255) NOT NULL,
				[Active] [bit] NOT NULL,
				[UpdateTimeStamp] [datetime] NULL,
			 CONSTRAINT [PK__paContac__3214EC07D613F51D] PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[pCustomerUploadFile]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[pCustomerUploadFile](
				[id] [int] IDENTITY(1,1) NOT NULL,
				[file_name] [nvarchar](255) NULL,
				[file_path] [nvarchar](255) NULL,
				[Email] [nvarchar](255) NOT NULL,
				[ParentKey] [nvarchar](255) NULL,
				[ParentCompanyId] [int] NULL,
				[created_at] [datetime] NULL,
				[ProductName] [varchar](255) NULL,
			 CONSTRAINT [PK__pCustome__3213E83F42B00016] PRIMARY KEY CLUSTERED
			(
				[id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Period]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Period](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[PeriodNumber] [int] NOT NULL,
				[Year] [int] NOT NULL,
				[Month] [varchar](9) NOT NULL,
				[StartDate] [datetime] NOT NULL,
				[EndDate] [datetime] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			 CONSTRAINT [con_pk_period] PRIMARY KEY CLUSTERED
			(
				[PeriodNumber] ASC,
				[Year] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Plant]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Plant](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[BranchId] [varchar](4) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[DivId] [varchar](2) NOT NULL,
				[Name] [varchar](100) NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
			UNIQUE NONCLUSTERED
			(
				[CompanyId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
			UNIQUE NONCLUSTERED
			(
				[BranchId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
			UNIQUE NONCLUSTERED
			(
				[DivId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[pnContact]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[pnContact](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CustomerName] [nvarchar](75) NULL,
				[CustomerWebsite] [nvarchar](75) NULL,
				[CustomerLocation] [nvarchar](255) NULL,
				[TableName] [nvarchar](20) NULL,
				[Contact] [nvarchar](50) NULL,
				[ContactPrty] [int] NULL,
				[ContactType] [nvarchar](100) NULL,
				[FirstName] [nvarchar](100) NULL,
				[LastName] [nvarchar](100) NULL,
				[Email] [nvarchar](255) NOT NULL,
				[Active] [bit] NOT NULL,
				[Phone] [nvarchar](50) NULL,
				[LeadSource] [nvarchar](255) NULL,
				[UpdateTimeStamp] [datetime] NULL,
			 CONSTRAINT [PK__pnContac__3214EC074B8C4241] PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[pnProduct]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[pnProduct](
				[Id] [int] NOT NULL,
				[CompanyId] [int] NULL,
				[CustomerName] [int] NULL,
				[ProductId] [int] NULL,
				[Description] [nvarchar](255) NULL,
				[CustPart] [nvarchar](100) NULL,
				[MType] [nvarchar](50) NULL,
				[Active] [bit] NULL,
				[NetWgt] [decimal](10, 5) NULL,
				[UpdateTimeStamp] [datetime] NULL,
				[QuoteNumber] [nvarchar](50) NULL,
				[Status] [nvarchar](50) NULL,
			PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[PODate]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[PODate](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[PONumber] [int] NOT NULL,
				[POItem] [int] NOT NULL,
				[RelNum] [int] NOT NULL,
				[PromiseDate] [datetime] NOT NULL,
				[RequestDate] [datetime] NOT NULL,
				[RequestQty] [decimal](14, 2) NOT NULL,
				[Complete] [bit] NOT NULL,
				[RecvDate] [datetime] NULL,
				[RecvQty] [decimal](14, 2) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[POHeader]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[POHeader](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[SupplierId] [varchar](10) NOT NULL,
				[PONumber] [int] NOT NULL,
				[PurchAgent] [varchar](4) NULL,
				[Closed] [bit] NOT NULL,
				[PoDate] [datetime] NOT NULL,
				[CurrCode] [varchar](4) NOT NULL,
				[Termcode] [varchar](4) NOT NULL,
				[ACKStatus] [varchar](1) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[POItem]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[POItem](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[PONumber] [int] NOT NULL,
				[POItem] [int] NOT NULL,
				[SupplierId] [varchar](10) NOT NULL,
				[OrderType] [varchar](1) NULL,
				[OrderNumber] [int] NOT NULL,
				[OrderItem] [int] NOT NULL,
				[NoCharge] [bit] NOT NULL,
				[GroupCode] [varchar](4) NULL,
				[PurchasedCasting] [bit] NOT NULL,
				[UnitPrice] [decimal](20, 5) NOT NULL,
				[OrderQty] [decimal](14, 2) NOT NULL,
				[RecvQty] [decimal](14, 2) NOT NULL,
				[ReturnQty] [decimal](14, 2) NOT NULL,
				[Complete] [bit] NOT NULL,
				[UnitMeas] [varchar](4) NOT NULL,
				[MatlDesc1] [varchar](50) NULL,
				[MaterialID] [varchar](22) NULL,
				[Requester] [varchar](20) NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[pPOHeaderTransfer]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[pPOHeaderTransfer](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[SupplierId] [varchar](10) NOT NULL,
				[PONumber] [int] NULL,
				[PurchAgent] [varchar](4) NULL,
				[Closed] [bit] NULL,
				[PoDate] [datetime] NULL,
				[CurrCode] [varchar](4) NULL,
				[Termcode] [varchar](4) NULL,
				[ACKStatus] [varchar](1) NULL,
				[OdyUniqueId] [bigint] NULL,
				[UpdateTimeStamp] [datetime] NULL,
				[Processed] [bit] NULL,
			PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Product]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Product](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CustomerId] [varchar](10) NOT NULL,
				[ProductId] [varchar](22) NOT NULL,
				[Description] [varchar](50) NOT NULL,
				[CustPart] [varchar](35) NOT NULL,
				[MType] [varchar](10) NOT NULL,
				[Active] [bit] NOT NULL,
				[NetWgt] [decimal](16, 5) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ProductCost]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ProductCost](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[BOMFixOHDollars] [decimal](18, 5) NULL,
				[BOMFixOHScrapDollars] [decimal](18, 5) NULL,
				[BOMLaborDollars] [decimal](18, 5) NULL,
				[BOMLaborScrapDollars] [decimal](18, 5) NULL,
				[BOMMatlDollars] [decimal](18, 5) NULL,
				[BOMMatlScrapDollars] [decimal](18, 5) NULL,
				[BOMVarOHDollars] [decimal](18, 5) NULL,
				[BOMVarOHScrapDollars] [decimal](18, 5) NULL,
				[CompanyID] [varchar](4) NOT NULL,
				[CoreFixOHDollars] [decimal](18, 5) NULL,
				[CoreFixOHScrapDollars] [decimal](18, 5) NULL,
				[CoreLaborDollars] [decimal](18, 5) NULL,
				[CoreLaborScrapDollars] [decimal](18, 5) NULL,
				[CoreMatlDollars] [decimal](18, 5) NULL,
				[CoreMatlScrapDollars] [decimal](18, 5) NULL,
				[CoreVarOHDollars] [decimal](18, 5) NULL,
				[CoreVarOHScrapDollars] [decimal](18, 5) NULL,
				[CostType] [varchar](1) NULL,
				[LastCostDate] [date] NULL,
				[MTypeCostLb] [decimal](18, 5) NULL,
				[MTypeDollars] [decimal](18, 5) NULL,
				[MTypeGrossDollars] [decimal](18, 5) NULL,
				[MTypeLossDollar] [decimal](18, 5) NULL,
				[MTypePrice] [decimal](18, 5) NULL,
				[MTypeScrapDollars] [decimal](18, 5) NULL,
				[MTypeSprueDollars] [decimal](18, 5) NULL,
				[OrderItem] [int] NULL,
				[OrderNumber] [int] NULL,
				[OSCostDollars] [decimal](18, 5) NULL,
				[OSScrapDollars] [decimal](18, 5) NULL,
				[ParentId] [bigint] NULL,
				[PrevSetupFixedOH] [decimal](18, 5) NULL,
				[PrevSetupFixedOHEach] [decimal](18, 5) NULL,
				[PrevSetupLabor] [decimal](18, 5) NULL,
				[PrevSetupLaborEach] [decimal](18, 5) NULL,
				[PrevSetupMatl] [decimal](18, 5) NULL,
				[PrevSetupMatlEach] [decimal](18, 5) NULL,
				[PrevSetupVarOH] [decimal](18, 5) NULL,
				[PrevSetupVarOHEach] [decimal](18, 5) NULL,
				[PrevToolingFixOH] [decimal](18, 5) NULL,
				[PrevToolingLabor] [decimal](18, 5) NULL,
				[PrevToolingMatl] [decimal](18, 5) NULL,
				[PrevToolingSetup] [decimal](18, 5) NULL,
				[PrevToolingVarOH] [decimal](18, 5) NULL,
				[ProductQuote] [varchar](22) NULL,
				[QP] [varchar](1) NULL,
				[RtgCode] [varchar](10) NULL,
				[RtgFixedOHDollars] [decimal](18, 5) NULL,
				[RtgLaborDollars] [decimal](18, 5) NULL,
				[RtgScrapBOMDollars] [decimal](18, 5) NULL,
				[RtgScrapFixOHDollars] [decimal](18, 5) NULL,
				[RtgScrapLaborDollars] [decimal](18, 5) NULL,
				[RtgScrapMetalDollars] [decimal](18, 5) NULL,
				[RtgScrapVarOHDollars] [decimal](18, 5) NULL,
				[RtgVarOHDollars] [decimal](18, 5) NULL,
				[SetupFixedOHDollars] [decimal](18, 5) NULL,
				[SetupFixedOHEach] [decimal](18, 5) NULL,
				[SetupLaborDollars] [decimal](18, 5) NULL,
				[SetupLaborEach] [decimal](18, 5) NULL,
				[SetupMatlDollars] [decimal](18, 5) NULL,
				[SetupMatlEach] [decimal](18, 5) NULL,
				[SetupVarOHDollars] [decimal](18, 5) NULL,
				[SetupVarOHEach] [decimal](18, 5) NULL,
				[SprueCostLb] [decimal](18, 5) NULL,
				[ToolingCost] [decimal](18, 5) NULL,
				[ToolingFixOHDollars] [decimal](18, 5) NULL,
				[ToolingFixOHMU] [decimal](18, 5) NULL,
				[ToolingHours] [decimal](10, 2) NULL,
				[ToolingLaborDollars] [decimal](18, 5) NULL,
				[ToolingLaborMU] [decimal](18, 5) NULL,
				[ToolingMatlDollars] [decimal](18, 5) NULL,
				[ToolingMatlMU] [decimal](18, 5) NULL,
				[ToolingPrice] [decimal](18, 5) NULL,
				[ToolingSetupDollars] [decimal](18, 5) NULL,
				[ToolingSetupHrs] [decimal](10, 2) NULL,
				[ToolingVarOHDollars] [decimal](18, 5) NULL,
				[ToolingVarOHMU] [decimal](18, 5) NULL,
				[OdyUniqueId] [int] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ProductionHistory]    Script Date: 21.10.2024 19:46:15 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ProductionHistory](
				[Id] [int] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[Account] [varchar](15) NULL,
				[Actfovh] [decimal](20, 5) NULL,
				[Actlabr] [decimal](20, 5) NULL,
				[Actvovh] [decimal](20, 5) NULL,
				[AddtoBox] [bit] NULL,
				[AdjStartAP] [char](2) NULL,
				[AdjStartDate] [datetime] NULL,
				[AdjStartTime] [char](5) NULL,
				[AdjStopAP] [char](2) NULL,
				[AdjStopDate] [datetime] NULL,
				[AdjStopTime] [varchar](5) NULL,
				[Adjustment] [bit] NULL,
				[AfterRecipeRelief] [bit] NULL,
				[AutoAllocated] [bit] NULL,
				[AutoAllocatedProd] [bit] NULL,
				[AutoAllocProdMeth] [char](1) NULL,
				[AutoCrewOut] [bit] NULL,
				[AutoDT] [bit] NULL,
				[AutoMoldPour] [bit] NULL,
				[Badge] [varchar](10) NULL,
				[BookQty] [int] NULL,
				[BreakTime] [decimal](10, 2) NULL,
				[BudgetCode] [varchar](5) NULL,
				[ByToolParent] [bit] NULL,
				[CalculatedShots] [int] NULL,
				[CastDate] [datetime] NULL,
				[Cellcount] [int] NULL,
				[Chgflag] [char](1) NULL,
				[CITran] [bit] NULL,
				[CITranType] [varchar](10) NULL,
				[Clocknumber] [int] NULL,
				[Compgen] [bit] NULL,
				[Complete] [bit] NULL,
				[CompPrice] [decimal](20, 5) NULL,
				[Config] [varchar](8) NULL,
				[ConsLocType] [char](1) NULL,
				[ConsType] [char](1) NULL,
				[ContainerID] [int] NULL,
				[CostFlag] [char](1) NULL,
				[CreateWO] [bit] NULL,
				[Crew] [bit] NULL,
				[CrewCode] [varchar](10) NULL,
				[CrewCount] [int] NULL,
				[CrewLeader] [int] NULL,
				[Crewmember] [bit] NULL,
				[CustomerRework] [bit] NULL,
				[Date] [datetime] NULL,
				[Department] [int] NULL,
				[Division] [int] NULL,
				[DTTime] [decimal](10, 2) NULL,
				[Effqty] [int] NULL,
				[Elapsedmanminutes] [int] NULL,
				[ElapsedMin] [int] NULL,
				[EndingShots] [int] NULL,
				[Equipment] [varchar](22) NULL,
				[ExportLogID] [int] NULL,
				[ExportStatus] [char](1) NULL,
				[Familymolds] [int] NULL,
				[Foreman] [varchar](4) NULL,
				[FromLocation] [varchar](15) NULL,
				[FromSerialNumber] [varchar](25) NULL,
				[FromTrackingnumber] [int] NULL,
				[FrozenStdCost] [decimal](18, 5) NULL,
				[Frozfovh] [decimal](20, 5) NULL,
				[Frozlabr] [decimal](20, 5) NULL,
				[Frozvovh] [decimal](20, 5) NULL,
				[GenContainerID] [char](1) NULL,
				[GL05JV] [varchar](20) NULL,
				[GLPosted] [bit] NULL,
				[GrandParentID] [int] NULL,
				[GrossWgt] [decimal](16, 5) NULL,
				[Groupcode] [varchar](4) NULL,
				[Heatnumber] [varchar](15) NULL,
				[HeatTreat] [varchar](8) NULL,
				[Hours] [decimal](10, 2) NULL,
				[HrPunch] [bit] NULL,
				[InspectBy] [int] NULL,
				[InspectStatus] [char](1) NULL,
				[InterFaceFlag] [varchar](8) NULL,
				[InvAffected] [char](1) NULL,
				[InvLocation] [varchar](15) NULL,
				[JobNumber] [varchar](30) NULL,
				[LotNumber] [varchar](15) NULL,
				[LunchPunch] [bit] NULL,
				[LunchTime] [decimal](10, 2) NULL,
				[Manbreakhours] [decimal](13, 5) NULL,
				[Mandowntime] [decimal](10, 2) NULL,
				[Manhours] [decimal](13, 5) NULL,
				[Manlunchhours] [decimal](12, 4) NULL,
				[Manrate] [decimal](12, 4) NULL,
				[MasterContID] [int] NULL,
				[MoldBreakTime] [decimal](10, 2) NULL,
				[MoldDTTime] [decimal](10, 2) NULL,
				[MoldHours] [decimal](10, 2) NULL,
				[MoldLunchTime] [decimal](10, 2) NULL,
				[MoldsMade] [int] NULL,
				[MoldsNotPoured] [int] NULL,
				[MoldsPoured] [int] NULL,
				[MoldStopAP] [char](2) NULL,
				[MoldStopDate] [datetime] NULL,
				[MoldStopTime] [varchar](5) NULL,
				[MoldStopTimeDec] [decimal](5, 2) NULL,
				[Mtype] [varchar](10) NULL,
				[MultiSerial] [bit] NULL,
				[Netwgt] [decimal](16, 5) NULL,
				[NewContQty] [int] NULL,
				[Numbermachines] [int] NULL,
				[Numberon] [int] NULL,
				[NumOfBoxes] [bigint] NULL,
				[Operation] [varchar](10) NULL,
				[OPkgcode] [varchar](4) NULL,
				[Orderitem] [int] NULL,
				[Ordernumber] [int] NULL,
				[Ordertype] [varchar](2) NULL,
				[ParentEffqty] [int] NULL,
				[ParentID] [bigint] NULL,
				[ParentQty] [int] NULL,
				[ParentShots] [int] NULL,
				[PayDollars] [decimal](20, 5) NULL,
				[PayDollarType] [varchar](4) NULL,
				[PayHours] [decimal](10, 2) NULL,
				[PayMinutes] [int] NULL,
				[PayOvrd] [bit] NULL,
				[PayOvrdBy] [varchar](12) NULL,
				[PayOvrdDate] [datetime] NULL,
				[PayOvrdRsn] [varchar](4) NULL,
				[PayRate] [decimal](20, 5) NULL,
				[PickListNbr] [int] NULL,
				[PiecesPerBox] [int] NULL,
				[Pkgcode] [varchar](4) NULL,
				[PMnumber] [int] NULL,
				[PostPeriod] [int] NULL,
				[PostYear] [int] NULL,
				[ProdID] [int] NULL,
				[Product] [varchar](44) NULL,
				[ProductionInterface] [bit] NULL,
				[ProductType] [char](1) NULL,
				[PSNumber] [int] NULL,
				[PSRtgseq] [int] NULL,
				[PunchElapsedTime] [decimal](10, 2) NULL,
				[PunchStartAP] [char](2) NULL,
				[PunchStartDate] [datetime] NULL,
				[PunchStartTime] [varchar](5) NULL,
				[PunchStartTimeDec] [decimal](5, 2) NULL,
				[PunchStopAP] [char](2) NULL,
				[PunchStopDate] [datetime] NULL,
				[PunchStopTime] [varchar](5) NULL,
				[PunchStopTimeDec] [decimal](5, 2) NULL,
				[PurchasedCasting] [bit] NULL,
				[Qty] [int] NULL,
				[RCSerialNbr] [varchar](25) NULL,
				[Reading] [decimal](26, 9) NULL,
				[Reasoncode] [varchar](4) NULL,
				[RecipeRelief] [bit] NULL,
				[Relnumber] [int] NULL,
				[Remarks] [varchar](300) NULL,
				[ReportSeries] [varchar](25) NULL,
				[ReturnCode] [bit] NULL,
				[ReturnDollars] [decimal](15, 2) NULL,
				[ReworkRtg] [bit] NULL,
				[ReworkRtgCode] [varchar](10) NULL,
				[RMAAutoCreated] [bit] NULL,
				[RMAItem] [int] NULL,
				[RMANumber] [int] NULL,
				[RMAType] [char](1) NULL,
				[RtgCode] [varchar](10) NULL,
				[RtgRate] [decimal](12, 4) NULL,
				[RtgSeq] [int] NULL,
				[RtgSeqID] [int] NULL,
				[RunNumber] [varchar](15) NULL,
				[Sample] [bit] NULL,
				[SampleType] [char](2) NULL,
				[SampleWeight] [decimal](16, 5) NULL,
				[SampleWgtEa] [decimal](16, 5) NULL,
				[SampleWgtVariance] [bit] NULL,
				[SampleWQty] [int] NULL,
				[ScrapOperation] [varchar](10) NULL,
				[ScrappedAt] [char](1) NULL,
				[ScrapSeq] [int] NULL,
				[ScreenID] [varchar](30) NULL,
				[SerialLevel] [char](1) NULL,
				[SerialNumLen] [int] NULL,
				[SerialPrefix] [varchar](6) NULL,
				[SerialSuffix] [varchar](6) NULL,
				[Setup] [bit] NULL,
				[Shift] [char](1) NULL,
				[ShiftSchedule] [varchar](4) NULL,
				[ShipmentID] [int] NULL,
				[ShipWgt] [int] NULL,
				[Shots] [int] NULL,
				[Source] [varchar](10) NULL,
				[StageMethod] [char](1) NULL,
				[Staging] [bit] NULL,
				[StartingShots] [int] NULL,
				[StartTime] [decimal](5, 2) NULL,
				[StdCost] [decimal](18, 5) NULL,
				[StdFGCost] [decimal](18, 5) NULL,
				[StdFovh] [decimal](20, 5) NULL,
				[StdHours] [decimal](10, 2) NULL,
				[StdLabr] [decimal](20, 5) NULL,
				[StdOperation] [varchar](10) NULL,
				[StdRtgseq] [int] NULL,
				[StdSeqID] [int] NULL,
				[StdVovh] [decimal](20, 5) NULL,
				[StdWipCost] [decimal](18, 5) NULL,
				[StopTime] [decimal](5, 2) NULL,
				[SumPeriod] [int] NULL,
				[SumYear] [int] NULL,
				[TareWgt] [decimal](16, 5) NULL,
				[Temp] [bit] NULL,
				[TimeCardID] [int] NULL,
				[TimeSlotDate] [datetime] NULL,
				[TimeSlotHR] [int] NULL,
				[TimeSlotTR] [int] NULL,
				[Tool] [varchar](22) NULL,
				[Toserialnumber] [varchar](25) NULL,
				[TotalNumberon] [int] NULL,
				[Totalparts] [int] NULL,
				[Totalwgt] [decimal](16, 5) NULL,
				[ToTrackingnumber] [int] NULL,
				[TPCumShip] [int] NULL,
				[Transcode] [char](2) NULL,
				[ValueAt] [char](1) NULL,
				[Verified] [bit] NULL,
				[Void] [bit] NULL,
				[WebServiceIDPost] [varchar](25) NULL,
				[WebServiceIDPostOff] [varchar](25) NULL,
				[WebServiceIDPostResults] [varchar](332) NULL,
				[WebServiceIDPostResultsOff] [varchar](332) NULL,
				[WebServiceIDPre] [varchar](25) NULL,
				[WebServiceIDPreOff] [varchar](25) NULL,
				[WebServiceIDPreResults] [varchar](332) NULL,
				[WebServiceIDPreResultsOff] [varchar](332) NULL,
				[Workcenter] [char](3) NULL,
				[WorkEffqty] [int] NULL,
				[WriteSH] [bit] NULL,
				[OdyUniqueId] [int] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[PRODUCTSX]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[PRODUCTSX](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[FLAGS] [varchar](max) NULL,
				[PARENTID] [int] NULL,
				[X_N00001] [int] NULL,
				[X_N00002] [decimal](20, 5) NULL,
				[X_N00003] [int] NULL,
				[X_N00004] [int] NULL,
				[X_A00005] [varchar](15) NULL,
				[X_D00006] [date] NULL,
				[X_A00007] [varchar](15) NULL,
				[X_D00008] [date] NULL,
				[X_A00009] [varchar](15) NULL,
				[X_D00010] [date] NULL,
				[X_A00011] [varchar](15) NULL,
				[X_N00014] [decimal](20, 5) NULL,
				[X_N00015] [decimal](20, 5) NULL,
				[X_N00016] [decimal](20, 5) NULL,
				[X_N00017] [decimal](20, 5) NULL,
				[X_N00018] [int] NULL,
				[X_N00019] [int] NULL,
				[X_A00020] [varchar](15) NULL,
				[X_A00021] [varchar](25) NULL,
				[X_N00022] [decimal](20, 5) NULL,
				[X_D00023] [date] NULL,
				[X_N00024] [decimal](20, 5) NULL,
				[X_D00025] [date] NULL,
				[X_N00026] [decimal](20, 5) NULL,
				[X_D00027] [date] NULL,
				[X_N00028] [decimal](20, 5) NULL,
				[X_D00029] [date] NULL,
				[X_N00030] [decimal](20, 5) NULL,
				[X_D00031] [date] NULL,
				[X_A00032] [varchar](15) NULL,
				[X_A00033] [varchar](15) NULL,
				[x_BasePrice] [decimal](16, 7) NULL,
				[x_FGSkid] [int] NULL,
				[x_FGStackHeight] [int] NULL,
				[x_RackStorage] [bit] NULL,
				[x_surcharge] [decimal](16, 7) NULL,
				[x_WIPSkid] [int] NULL,
				[x_WIPStackHeight] [int] NULL,
				[x_StandardSalesPrice] [decimal](16, 7) NULL,
				[x_MultiLevel] [varchar](50) NULL,
				[x_ProductCategory] [varchar](50) NULL,
				[x_InsertWeight] [decimal](14, 5) NULL,
				[x_EquiSeq] [bigint] NULL,
				[x_EquiValueEach] [decimal](16, 5) NULL,
				[x_ProdMatlCost] [decimal](16, 5) NULL,
				[x_Service] [bit] NULL,
				[x_ServiceDate] [date] NULL,
				[x_StartProdDate] [date] NULL,
				[x_OEM] [varchar](35) NULL,
				[x_Platform] [varchar](35) NULL,
				[x_Type] [varchar](50) NULL,
				[x_QuoteMarginPercentage] [decimal](16, 5) NULL,
				[x_EAU] [bigint] NULL,
				[x_MarketStack] [varchar](35) NULL,
				[x_EndProduct] [varchar](50) NULL,
				[x_ProgramName] [varchar](100) NULL,
				[x_HaveSonicProgram] [varchar](15) NULL,
				[x_CertShip-To] [varchar](15) NULL,
				[x_SendCertToCust] [varchar](15) NULL,
				[x_DefaultBottomBoard] [varchar](15) NULL,
				[x_D_ScaleNetTarget] [decimal](16, 5) NULL,
				[x_D_ScaleNetTolerance] [decimal](16, 5) NULL,
				[x_FA_BHN_TestPieces] [int] NULL,
				[x_FA_RF_TestPieces] [int] NULL,
				[x_FRACCIONARANCELARIA] [varchar](50) NULL,
				[X_FAVisualSamplePcs] [int] NULL,
				[X_HotPullTIRLow] [decimal](20, 5) NULL,
				[X_HotPullTIRHi] [decimal](20, 5) NULL,
				[X_HotPullCrossPLLow] [decimal](20, 5) NULL,
				[X_HotPullCrossPLHi] [decimal](20, 5) NULL,
				[x_PRODUCTCODE] [varchar](35) NULL,
				[x_UNIT_KEY] [varchar](35) NULL,
				[x_FutureCompPrice] [decimal](16, 5) NULL,
				[x_PastCompPrice] [decimal](16, 5) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL
			) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[pSupplierAck]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[pSupplierAck](
				[ParentCompanyId] [varchar](4) NULL,
				[ParentKey] [varchar](10) NULL,
				[UpdateTimeStamp] [datetime] NULL,
				[Email] [varchar](255) NULL,
				[ack] [varchar](1) NULL,
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[pSupplierUploadASMT]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[pSupplierUploadASMT](
				[id] [int] IDENTITY(1,1) NOT NULL,
				[file_name] [varchar](255) NULL,
				[file_path] [varchar](1000) NULL,
				[Email] [varchar](100) NULL,
				[ParentKey] [varchar](100) NULL,
				[ParentCompanyId] [varchar](100) NULL,
				[created_at] [datetime] NULL,
			 CONSTRAINT [PK_pSupplierUploadASMT] PRIMARY KEY CLUSTERED
			(
				[id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[pSupplierUploadFile]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[pSupplierUploadFile](
				[id] [int] IDENTITY(1,1) NOT NULL,
				[file_name] [varchar](255) NULL,
				[file_path] [varchar](1000) NULL,
				[Email] [varchar](100) NOT NULL,
				[ParentKey] [varchar](100) NULL,
				[ParentCompanyId] [varchar](100) NULL,
				[created_at] [datetime] NULL,
			 CONSTRAINT [PK__pSupplie__3213E83FB185A255] PRIMARY KEY CLUSTERED
			(
				[id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[PW]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[PW](
				[PW_id] [int] IDENTITY(1,1) NOT NULL,
				[email] [varchar](100) NOT NULL,
				[password_hash] [varchar](255) NOT NULL,
				[salt] [varchar](255) NOT NULL,
				[created_at] [datetime] NULL,
				[updated_at] [datetime] NULL,
			PRIMARY KEY CLUSTERED
			(
				[PW_id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
			UNIQUE NONCLUSTERED
			(
				[email] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[qwsOpportunity_List]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[qwsOpportunity_List](
				[Title] [varchar](255) NULL,
				[MarketSegment] [varchar](100) NULL,
				[Customer] [varchar](255) NULL,
				[Status] [varchar](100) NULL,
				[Status_Title] [varchar](255) NULL,
				[Notes] [text] NULL,
				[ProgressValue] [decimal](5, 2) NULL,
				[MarketSegment_ID] [int] NULL,
				[MarketSegment_ID_Title] [varchar](255) NULL,
				[In_Salesforce] [bit] NULL,
				[Salesforce_Link] [varchar](255) NULL,
				[TestingOnly] [bit] NULL,
				[SalesForce_RFQ_ID] [varchar](50) NULL,
				[SF_Opportunity_Type] [varchar](100) NULL,
				[SF_Stage] [varchar](100) NULL,
				[SF_MarketStack] [varchar](100) NULL,
				[SF_Plant] [varchar](100) NULL,
				[ID] [varchar](50) NOT NULL,
				[SF_CloseDate] [date] NULL,
				[SF_Created_Date] [date] NULL,
				[Account_Manager_ID] [varchar](50) NULL,
				[Customer_SF_ID] [varchar](50) NULL,
				[SF_Conf_Level] [varchar](50) NULL,
				[SF_Cust_Stage] [varchar](100) NULL,
				[RowID] [int] IDENTITY(1,1) NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[ID] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ReqDate]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ReqDate](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[ReqNumber] [int] NOT NULL,
				[ReqItem] [int] NOT NULL,
				[PromiseDate] [datetime] NULL,
				[RequestDate] [datetime] NOT NULL,
				[RequestQty] [decimal](14, 2) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ReqHdr]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ReqHdr](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[SupplierId] [varchar](10) NULL,
				[ReqNumber] [int] NOT NULL,
				[PurchAgent] [varchar](4) NULL,
				[Closed] [bit] NULL,
				[CurrCode] [varchar](4) NULL,
				[EnteredBy] [varchar](12) NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ReqItem]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ReqItem](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[ReqNumber] [int] NOT NULL,
				[ReqItem] [int] NOT NULL,
				[Description] [varchar](50) NULL,
				[Description2] [varchar](50) NULL,
				[EnteredBy] [varchar](12) NOT NULL,
				[InvType] [varchar](4) NOT NULL,
				[ItemStatus] [varchar](1) NOT NULL,
				[MaterialId] [varchar](22) NULL,
				[OrderBy] [datetime] NULL,
				[RequestedBy] [varchar](20) NULL,
				[OrderQty] [decimal](14, 2) NOT NULL,
				[UnitPrice] [decimal](20, 5) NOT NULL,
				[UpdatePrice] [bit] NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[RoutingCost]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[RoutingCost](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[BOMFixOHDollars] [decimal](18, 5) NULL,
				[BOMFixOHScrapDollars] [decimal](18, 5) NULL,
				[BOMLaborDollars] [decimal](18, 5) NULL,
				[BOMLaborScrapDollars] [decimal](18, 5) NULL,
				[BOMMatlDollars] [decimal](18, 5) NULL,
				[BOMMatlScrapDollars] [decimal](18, 5) NULL,
				[BOMVarOHDollars] [decimal](18, 5) NULL,
				[BOMVarOHScrapDollars] [decimal](18, 5) NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CostType] [varchar](1) NULL,
				[CummBOMF] [decimal](18, 5) NULL,
				[CummBOMFS] [decimal](18, 5) NULL,
				[CummBOML] [decimal](18, 5) NULL,
				[CummBOMLS] [decimal](18, 5) NULL,
				[CummBOMm] [decimal](18, 5) NULL,
				[CummBOMmS] [decimal](18, 5) NULL,
				[CummBOMV] [decimal](18, 5) NULL,
				[CummBOMVS] [decimal](18, 5) NULL,
				[CummFixed] [decimal](18, 5) NULL,
				[CummFixedS] [decimal](18, 5) NULL,
				[CummLabor] [decimal](18, 5) NULL,
				[CummLaborS] [decimal](18, 5) NULL,
				[CummMetal] [decimal](18, 5) NULL,
				[CummMetalS] [decimal](18, 5) NULL,
				[CummVar] [decimal](18, 5) NULL,
				[CummVarS] [decimal](18, 5) NULL,
				[FOVHRate] [decimal](20, 5) NULL,
				[LaborRate] [decimal](20, 5) NULL,
				[LastCostDate] [date] NULL,
				[MachFOVHRate] [decimal](20, 5) NULL,
				[MachLaborRate] [decimal](20, 5) NULL,
				[MachVOVHRate] [decimal](20, 5) NULL,
				[OrderItem] [int] NULL,
				[OrderNumber] [int] NULL,
				[ParentId] [bigint] NULL,
				[ProductQuote] [varchar](22) NULL,
				[QP] [varchar](1) NULL,
				[RtgCode] [varchar](10) NULL,
				[RtgFixedOHDollars] [decimal](18, 5) NULL,
				[RtgLaborDollars] [decimal](18, 5) NULL,
				[RtgScrapBOMDollars] [decimal](18, 5) NULL,
				[RtgScrapFixOHDollars] [decimal](18, 5) NULL,
				[RtgScrapLaborDollars] [decimal](18, 5) NULL,
				[RtgScrapMetalDollars] [decimal](18, 5) NULL,
				[RtgScrapVarOHDollars] [decimal](18, 5) NULL,
				[RtgSeq] [int] NULL,
				[RtgVarOHDollars] [decimal](18, 5) NULL,
				[SetupFixedOHDollarRate] [decimal](20, 5) NULL,
				[SetupFixOHDollars] [decimal](18, 5) NULL,
				[SetupFixOHDollarsEach] [decimal](18, 5) NULL,
				[SetupLaborDollarRate] [decimal](20, 5) NULL,
				[SetupLaborDollars] [decimal](18, 5) NULL,
				[SetupLaborDollarsEach] [decimal](18, 5) NULL,
				[SetupMatlDollarsEach] [decimal](18, 5) NULL,
				[SetupVarOHDollarRate] [decimal](20, 5) NULL,
				[SetupVarOHDollars] [decimal](18, 5) NULL,
				[SetupVarOHDollarsEach] [decimal](18, 5) NULL,
				[ToolHours] [decimal](10, 2) NULL,
				[ToolSetupHours] [decimal](10, 2) NULL,
				[ToolType] [bit] NULL,
				[OdyUniqueId] [int] NOT NULL,
				[VOVHRate] [decimal](20, 5) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[RoutingDtl]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[RoutingDtl](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[Active] [bit] NULL,
				[AffectCost] [bit] NULL,
				[AffectProductStatus] [bit] NULL,
				[AffectSched] [bit] NULL,
				[Alternate] [bit] NULL,
				[Auto32] [bit] NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[Config] [varchar](8) NULL,
				[DayQty] [bigint] NULL,
				[EmailAddressJobOff] [varchar](255) NULL,
				[EmailAddressJobOn] [varchar](255) NULL,
				[EmailJobOff] [bit] NULL,
				[EmailJobOn] [bit] NULL,
				[EnableFeedBack] [varchar](1) NULL,
				[EstRate] [bit] NULL,
				[HTCycle] [varchar](10) NULL,
				[MachHrsPc] [decimal](16, 5) NULL,
				[MachineRate] [decimal](16, 5) NULL,
				[ManHrsPc] [decimal](16, 5) NULL,
				[ManRate] [decimal](16, 5) NULL,
				[Operation] [varchar](10) NULL,
				[OverlapDayHrs] [varchar](1) NULL,
				[OverlapDays] [bigint] NULL,
				[OverlapHrs] [decimal](10, 2) NULL,
				[OverlapMethod] [varchar](2) NULL,
				[OverridePercent] [decimal](9, 2) NULL,
				[OverrideQty] [bigint] NULL,
				[PrioritySequence] [int] NULL,
				[Product] [varchar](22) NULL,
				[ReworkRtg] [bit] NULL,
				[Round] [bit] NULL,
				[RtgCode] [varchar](10) NULL,
				[RtgSeq] [int] NULL,
				[SameAsStandard] [bit] NULL,
				[ScheduleDays] [int] NULL,
				[ScheduleDecimals] [bit] NULL,
				[ScrapPct] [decimal](7, 3) NULL,
				[SetupRate] [decimal](9, 2) NULL,
				[SFQProcessSeries] [varchar](35) NULL,
				[ShipDestination] [varchar](1) NULL,
				[SOPrintGroup] [varchar](4) NULL,
				[StdRtg] [bit] NULL,
				[SupplierId] [varchar](10) NULL,
				[Tool] [varchar](22) NULL,
				[OdyUniqueID] [bigint] NOT NULL,
				[UseBOM] [varchar](1) NULL,
				[UseCal] [bit] NULL,
				[UseComments] [varchar](1) NULL,
				[UseStdCustomerSpec] [bit] NULL,
				[UseStdEmailNotifiers] [bit] NULL,
				[UseStdLinks] [bit] NULL,
				[UseStdProcessSpec] [bit] NULL,
				[UseXref] [varchar](1) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueID] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[RoutingHdr]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[RoutingHdr](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[Active] [bit] NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[ConfigType] [varchar](4) NULL,
				[CurrentRtg] [bit] NULL,
				[Description] [varchar](50) NULL,
				[MasterTool] [varchar](22) NULL,
				[PendingRtg] [bit] NULL,
				[PendingRtgCode] [varchar](10) NULL,
				[Priority] [int] NULL,
				[Product] [varchar](22) NULL,
				[PurchasedCasting] [bit] NULL,
				[ReqConfiguring] [bit] NULL,
				[RevDate] [date] NULL,
				[Revision] [varchar](10) NULL,
				[ReworkRtg] [bit] NULL,
				[RtgCode] [varchar](10) NULL,
				[SFQDisplayLabel] [varchar](20) NULL,
				[StdRtg] [bit] NULL,
				[ToolPositions] [int] NULL,
				[OdyUniqueId] [int] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[SalesHistoryDtl]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[SalesHistoryDtl](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[ProductId] [varchar](22) NOT NULL,
				[CustomerId] [varchar](10) NOT NULL,
				[ShipTo] [varchar](10) NOT NULL,
				[Period] [int] NOT NULL,
				[Year] [int] NOT NULL,
				[Quantity] [int] NOT NULL,
				[InvNumber] [int] NOT NULL,
				[Item] [int] NOT NULL,
				[UnitPrice] [decimal](20, 5) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
				[Date] [datetime] NULL,
				[InvDate] [datetime] NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ScrapReasons]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ScrapReasons](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[Active] [bit] NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[Description] [varchar](50) NULL,
				[ReasonCode] [varchar](4) NULL,
				[ScrapType] [varchar](1) NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ShipTo]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ShipTo](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[CustomerId] [varchar](10) NOT NULL,
				[OdyShipToId] [varchar](10) NOT NULL,
				[ShipToName] [varchar](35) NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ShopOrder]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ShopOrder](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[AutoCreated] [bit] NULL,
				[BaseMtype] [varchar](10) NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[Complete] [bit] NULL,
				[CompPrice] [decimal](20, 5) NULL,
				[Config] [varchar](8) NULL,
				[ConfigOption] [varchar](1) NULL,
				[ConfigType] [varchar](4) NULL,
				[Customer] [varchar](10) NULL,
				[EqCompDemand] [bit] NULL,
				[Family] [bit] NULL,
				[FlaskCooling] [int] NULL,
				[Flasksize] [varchar](10) NULL,
				[Flasksize1] [decimal](11, 5) NULL,
				[Flasksize2] [decimal](11, 5) NULL,
				[Flasksize3] [decimal](11, 5) NULL,
				[GaugeConflict] [bit] NULL,
				[Groupcode] [varchar](4) NULL,
				[IFFullTree] [bit] NULL,
				[Inuse] [bit] NULL,
				[LLComplete] [bit] NULL,
				[LotDefaultedFrom] [varchar](1) NULL,
				[Lotnumber] [varchar](15) NULL,
				[MakeUpQty] [bigint] NULL,
				[MasterTool] [varchar](22) NULL,
				[MatlLbsReq] [decimal](15, 2) NULL,
				[MoldQty] [bigint] NULL,
				[MoldStartDate] [date] NULL,
				[MoldStartTime] [varchar](5) NULL,
				[MoldStopDate] [date] NULL,
				[MoldStopTime] [varchar](5) NULL,
				[Mtype] [varchar](10) NULL,
				[OClass] [varchar](4) NULL,
				[OrderChanges] [bit] NULL,
				[OrderItem] [int] NULL,
				[OrderNumber] [int] NULL,
				[OrderQty] [bigint] NULL,
				[OrigConfig] [varchar](8) NULL,
				[OrigFamily] [varchar](1) NULL,
				[OrigFamilySOID] [int] NULL,
				[OriginalDueDate] [date] NULL,
				[OrigTool] [varchar](22) NULL,
				[PcType] [varchar](1) NULL,
				[Planned] [bit] NULL,
				[Printstatus] [bit] NULL,
				[Product] [varchar](22) NULL,
				[ProductionQty] [bigint] NULL,
				[PurchasedCasting] [bit] NULL,
				[RtgCode] [varchar](10) NULL,
				[RtgStopped] [bit] NULL,
				[ScrapQty] [bigint] NULL,
				[ShopItem] [int] NULL,
				[ShopOrder] [int] NULL,
				[SOCreation] [varchar](8) NULL,
				[SODate] [date] NULL,
				[SODueDate] [date] NULL,
				[SOLock] [varchar](1) NULL,
				[SOStartDate] [date] NULL,
				[SOStatus] [varchar](1) NULL,
				[SOType] [varchar](1) NULL,
				[StopCode] [varchar](4) NULL,
				[Template] [bit] NULL,
				[Tool] [varchar](22) NULL,
				[ToolPositions] [int] NULL,
				[OdyUniqueId] [int] NOT NULL,
				[WorkCenter] [varchar](3) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[ShopRtg]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[ShopRtg](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[Complete] [bit] NULL,
				[CompleteDate] [date] NULL,
				[Config] [varchar](8) NULL,
				[CurrentSetup] [bit] NULL,
				[GaugeConflict] [bit] NULL,
				[HTCycle] [varchar](10) NULL,
				[LaborReported] [decimal](10, 2) NULL,
				[LastDate] [date] NULL,
				[LastTime] [int] NULL,
				[LastUser] [varchar](12) NULL,
				[MachineRate] [decimal](16, 5) NULL,
				[ManRate] [decimal](16, 5) NULL,
				[MoldOper] [bit] NULL,
				[Numberon] [int] NULL,
				[OldRtgQty] [bigint] NULL,
				[Operation] [varchar](10) NULL,
				[OperationType] [varchar](4) NULL,
				[OperLock] [varchar](1) NULL,
				[OurPONumber] [bigint] NULL,
				[OverlapDayHrs] [varchar](1) NULL,
				[OverlapDays] [int] NULL,
				[OverlapHrs] [decimal](10, 2) NULL,
				[OverlapMethod] [varchar](2) NULL,
				[OverridePercent] [decimal](9, 2) NULL,
				[OverrideQty] [int] NULL,
				[QtyOverride] [bit] NULL,
				[QtyProduced] [bigint] NULL,
				[QtyScrapped] [bigint] NULL,
				[RelieveRecipe] [bit] NULL,
				[RemainingMachine] [decimal](10, 2) NULL,
				[RemainingMan] [decimal](10, 2) NULL,
				[RemainingMolds] [bigint] NULL,
				[RemainingWgt] [decimal](15, 2) NULL,
				[RtgQty] [bigint] NULL,
				[RtgSeq] [int] NULL,
				[Scheduled] [bit] NULL,
				[ScheduleDays] [int] NULL,
				[ScheduleDecimals] [bit] NULL,
				[ScheduledMachine] [decimal](10, 2) NULL,
				[ScheduledMan] [decimal](10, 2) NULL,
				[ScheduledMolds] [bigint] NULL,
				[ScheduledSetup] [decimal](10, 2) NULL,
				[ScheduledWgt] [decimal](15, 2) NULL,
				[SchedulePriority] [int] NULL,
				[ScrapPct] [decimal](7, 3) NULL,
				[SetupHrs] [decimal](10, 2) NULL,
				[ShopItem] [int] NULL,
				[ShopOrder] [int] NULL,
				[ShopOrderId] [int] NULL,
				[SOPrintGroup] [varchar](4) NULL,
				[StartDate] [date] NULL,
				[StartTime] [varchar](5) NULL,
				[Stopcode] [varchar](4) NULL,
				[StopDate] [date] NULL,
				[StopTime] [varchar](5) NULL,
				[SupplierId] [varchar](10) NULL,
				[Tool] [varchar](22) NULL,
				[OdyUniqueId] [int] NOT NULL,
				[Wgt] [decimal](18, 5) NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[Supplier]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[Supplier](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[SupplierId] [varchar](10) NOT NULL,
				[CompanyId] [varchar](4) NOT NULL,
				[ApName] [varchar](50) NOT NULL,
				[PoName] [varchar](50) NULL,
				[Active] [bit] NOT NULL,
				[Termcode] [varchar](4) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
			 CONSTRAINT [con_unique_supplier_supplierid] UNIQUE NONCLUSTERED
			(
				[SupplierId] ASC,
				[CompanyId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[SupplierScoreHistory]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[SupplierScoreHistory](
				[Month] [datetime] NULL,
				[Supplier ID] [nvarchar](255) NULL,
				[Name] [nvarchar](255) NULL,
				[Master Commodity] [nvarchar](255) NULL,
				[Score] [float] NULL,
				[Rating] [nvarchar](255) NULL,
				[Payment Terms] [float] NULL,
				[OTD] [float] NULL,
				[Cost Savings] [float] NULL,
				[Open CAR/CI] [nvarchar](255) NULL,
				[Compliance Response] [float] NULL
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[SupplierX]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[SupplierX](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[ParentId] [bigint] NOT NULL,
				[MetalVendor] [varchar](15) NULL,
				[Critical] [bit] NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[Id] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[SupplierXDailyParents]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[SupplierXDailyParents](
				[ParentId] [bigint] NOT NULL
			) ON [PRIMARY]
			GO
			/****** Object:  Table [dbo].[User]    Script Date: 21.10.2024 19:46:16 ******/
			SET ANSI_NULLS ON
			GO
			SET QUOTED_IDENTIFIER ON
			GO
			CREATE TABLE [dbo].[User](
				[Id] [bigint] IDENTITY(1,1) NOT NULL,
				[UsersId] [varchar](12) NOT NULL,
				[OdyUniqueId] [bigint] NOT NULL,
				[UpdateTimeStamp] [datetime] NOT NULL,
			PRIMARY KEY CLUSTERED
			(
				[OdyUniqueId] ASC
			)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
			) ON [PRIMARY]
			GO
			ALTER TABLE [dbo].[APOpen] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[CompanyAddress] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Contact] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[CurrencyHistory] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Customer] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[CUSTOMERX] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Employees] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ForecastDtl] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Matltype] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[MissingProduct] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Operations] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[OrderDate] ADD  DEFAULT ((0)) FOR [Complete]
			GO
			ALTER TABLE [dbo].[OrderDate] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[OrderHeader] ADD  DEFAULT ((0)) FOR [ClosedFlag]
			GO
			ALTER TABLE [dbo].[OrderHeader] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[OrderItem] ADD  DEFAULT ((0)) FOR [Complete]
			GO
			ALTER TABLE [dbo].[OrderItem] ADD  DEFAULT ((0)) FOR [SellPrice]
			GO
			ALTER TABLE [dbo].[OrderItem] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Period] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Plant] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[PODate] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[POHeader] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[POItem] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Product] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ProductCost] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ProductionHistory] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[PRODUCTSX] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[pSupplierUploadFile] ADD  CONSTRAINT [DF__pSupplier__creat__0160A669]  DEFAULT (getdate()) FOR [created_at]
			GO
			ALTER TABLE [dbo].[PW] ADD  DEFAULT (getdate()) FOR [created_at]
			GO
			ALTER TABLE [dbo].[PW] ADD  DEFAULT (getdate()) FOR [updated_at]
			GO
			ALTER TABLE [dbo].[ReqDate] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ReqHdr] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ReqItem] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[RoutingCost] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[RoutingDtl] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[RoutingHdr] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[SalesHistoryDtl] ADD  DEFAULT ((0)) FOR [Quantity]
			GO
			ALTER TABLE [dbo].[SalesHistoryDtl] ADD  DEFAULT ((0)) FOR [UnitPrice]
			GO
			ALTER TABLE [dbo].[SalesHistoryDtl] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ScrapReasons] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ShipTo] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ShopOrder] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[ShopRtg] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[Supplier] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[SupplierX] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[User] ADD  DEFAULT (getdate()) FOR [UpdateTimeStamp]
			GO
			ALTER TABLE [dbo].[CompanyAddress]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[MissingProduct]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[Operations]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[Operations]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[ProductCost]  WITH CHECK ADD FOREIGN KEY([CompanyID])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[ProductCost]  WITH CHECK ADD FOREIGN KEY([CompanyID])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[RoutingCost]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[RoutingDtl]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[RoutingHdr]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[ScrapReasons]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[ScrapReasons]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[ShopOrder]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[ShopRtg]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD FOREIGN KEY([CompanyId])
			REFERENCES [dbo].[Plant] ([CompanyId])
			GO
			ALTER TABLE [dbo].[SupplierXDailyParents]  WITH CHECK ADD FOREIGN KEY([ParentId])
			REFERENCES [dbo].[Supplier] ([OdyUniqueId])
			GO
			";

        public static List<string> CustomPromts = new List<string>()
        {
            "",
        };
    }
}
