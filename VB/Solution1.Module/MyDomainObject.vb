Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace Solution1.Module
	<DefaultClassOptions> _
	Public Class MyDomainObject
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private field1_Renamed As String
		Public Property Field1() As String
			Set(ByVal value As String)
				SetPropertyValue("Field1", field1_Renamed, value)
			End Set
			Get
				Return field1_Renamed
			End Get
		End Property
		Private field2_Renamed As String
		Public Property Field2() As String
			Set(ByVal value As String)
				SetPropertyValue("Field2", field2_Renamed, value)
			End Set
			Get
				Return field2_Renamed
			End Get
		End Property
		Private field3_Renamed As String
		Public Property Field3() As String
			Set(ByVal value As String)
				SetPropertyValue("Field3", field3_Renamed, value)
			End Set
			Get
				Return field3_Renamed
			End Get
		End Property
		Private field4_Renamed As String
		Public Property Field4() As String
			Set(ByVal value As String)
				SetPropertyValue("Field4", field4_Renamed, value)
			End Set
			Get
				Return field4_Renamed
			End Get
		End Property
		Private field5_Renamed As String
		Public Property Field5() As String
			Set(ByVal value As String)
				SetPropertyValue("Field5", field5_Renamed, value)
			End Set
			Get
				Return field5_Renamed
			End Get
		End Property
	End Class

End Namespace
