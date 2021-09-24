CREATE TABLE [dbo].[Shipment](
	[ID] int primary key identity (1,1),
	[shipmentnum] [varchar](21) NOT NULL,
	[ShipmentDate] [datetime] NULL,
	[SndrCity] [varchar](23) NULL,
	[RecCity] [varchar](30) NULL,
	[OriginalWeight] decimal(10,2) NOT NULL
) ON [PRIMARY]
GO