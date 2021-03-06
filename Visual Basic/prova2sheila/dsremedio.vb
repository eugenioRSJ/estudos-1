﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsremedio
    Inherits DataSet
    
    Private tableremedios As remediosDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("remedios")) Is Nothing) Then
                Me.Tables.Add(New remediosDataTable(ds.Tables("remedios")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property remedios As remediosDataTable
        Get
            Return Me.tableremedios
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsremedio = CType(MyBase.Clone,dsremedio)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("remedios")) Is Nothing) Then
            Me.Tables.Add(New remediosDataTable(ds.Tables("remedios")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableremedios = CType(Me.Tables("remedios"),remediosDataTable)
        If (Not (Me.tableremedios) Is Nothing) Then
            Me.tableremedios.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsremedio"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsremedio.xsd"
        Me.Locale = New System.Globalization.CultureInfo("pt-BR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableremedios = New remediosDataTable
        Me.Tables.Add(Me.tableremedios)
    End Sub
    
    Private Function ShouldSerializeremedios() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub remediosRowChangeEventHandler(ByVal sender As Object, ByVal e As remediosRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class remediosDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columncodremedio As DataColumn
        
        Private columnindicacao As DataColumn
        
        Private columnpreco As DataColumn
        
        Private columnremedio As DataColumn
        
        Private columntipo As DataColumn
        
        Friend Sub New()
            MyBase.New("remedios")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property codremedioColumn As DataColumn
            Get
                Return Me.columncodremedio
            End Get
        End Property
        
        Friend ReadOnly Property indicacaoColumn As DataColumn
            Get
                Return Me.columnindicacao
            End Get
        End Property
        
        Friend ReadOnly Property precoColumn As DataColumn
            Get
                Return Me.columnpreco
            End Get
        End Property
        
        Friend ReadOnly Property remedioColumn As DataColumn
            Get
                Return Me.columnremedio
            End Get
        End Property
        
        Friend ReadOnly Property tipoColumn As DataColumn
            Get
                Return Me.columntipo
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As remediosRow
            Get
                Return CType(Me.Rows(index),remediosRow)
            End Get
        End Property
        
        Public Event remediosRowChanged As remediosRowChangeEventHandler
        
        Public Event remediosRowChanging As remediosRowChangeEventHandler
        
        Public Event remediosRowDeleted As remediosRowChangeEventHandler
        
        Public Event remediosRowDeleting As remediosRowChangeEventHandler
        
        Public Overloads Sub AddremediosRow(ByVal row As remediosRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddremediosRow(ByVal indicacao As String, ByVal preco As Decimal, ByVal remedio As String, ByVal tipo As String) As remediosRow
            Dim rowremediosRow As remediosRow = CType(Me.NewRow,remediosRow)
            rowremediosRow.ItemArray = New Object() {Nothing, indicacao, preco, remedio, tipo}
            Me.Rows.Add(rowremediosRow)
            Return rowremediosRow
        End Function
        
        Public Function FindBycodremedio(ByVal codremedio As Integer) As remediosRow
            Return CType(Me.Rows.Find(New Object() {codremedio}),remediosRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As remediosDataTable = CType(MyBase.Clone,remediosDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New remediosDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columncodremedio = Me.Columns("codremedio")
            Me.columnindicacao = Me.Columns("indicacao")
            Me.columnpreco = Me.Columns("preco")
            Me.columnremedio = Me.Columns("remedio")
            Me.columntipo = Me.Columns("tipo")
        End Sub
        
        Private Sub InitClass()
            Me.columncodremedio = New DataColumn("codremedio", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncodremedio)
            Me.columnindicacao = New DataColumn("indicacao", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnindicacao)
            Me.columnpreco = New DataColumn("preco", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpreco)
            Me.columnremedio = New DataColumn("remedio", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnremedio)
            Me.columntipo = New DataColumn("tipo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntipo)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columncodremedio}, true))
            Me.columncodremedio.AutoIncrement = true
            Me.columncodremedio.AllowDBNull = false
            Me.columncodremedio.Unique = true
        End Sub
        
        Public Function NewremediosRow() As remediosRow
            Return CType(Me.NewRow,remediosRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New remediosRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(remediosRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.remediosRowChangedEvent) Is Nothing) Then
                RaiseEvent remediosRowChanged(Me, New remediosRowChangeEvent(CType(e.Row,remediosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.remediosRowChangingEvent) Is Nothing) Then
                RaiseEvent remediosRowChanging(Me, New remediosRowChangeEvent(CType(e.Row,remediosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.remediosRowDeletedEvent) Is Nothing) Then
                RaiseEvent remediosRowDeleted(Me, New remediosRowChangeEvent(CType(e.Row,remediosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.remediosRowDeletingEvent) Is Nothing) Then
                RaiseEvent remediosRowDeleting(Me, New remediosRowChangeEvent(CType(e.Row,remediosRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveremediosRow(ByVal row As remediosRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class remediosRow
        Inherits DataRow
        
        Private tableremedios As remediosDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableremedios = CType(Me.Table,remediosDataTable)
        End Sub
        
        Public Property codremedio As Integer
            Get
                Return CType(Me(Me.tableremedios.codremedioColumn),Integer)
            End Get
            Set
                Me(Me.tableremedios.codremedioColumn) = value
            End Set
        End Property
        
        Public Property indicacao As String
            Get
                Try 
                    Return CType(Me(Me.tableremedios.indicacaoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableremedios.indicacaoColumn) = value
            End Set
        End Property
        
        Public Property preco As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableremedios.precoColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableremedios.precoColumn) = value
            End Set
        End Property
        
        Public Property remedio As String
            Get
                Try 
                    Return CType(Me(Me.tableremedios.remedioColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableremedios.remedioColumn) = value
            End Set
        End Property
        
        Public Property tipo As String
            Get
                Try 
                    Return CType(Me(Me.tableremedios.tipoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableremedios.tipoColumn) = value
            End Set
        End Property
        
        Public Function IsindicacaoNull() As Boolean
            Return Me.IsNull(Me.tableremedios.indicacaoColumn)
        End Function
        
        Public Sub SetindicacaoNull()
            Me(Me.tableremedios.indicacaoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsprecoNull() As Boolean
            Return Me.IsNull(Me.tableremedios.precoColumn)
        End Function
        
        Public Sub SetprecoNull()
            Me(Me.tableremedios.precoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsremedioNull() As Boolean
            Return Me.IsNull(Me.tableremedios.remedioColumn)
        End Function
        
        Public Sub SetremedioNull()
            Me(Me.tableremedios.remedioColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IstipoNull() As Boolean
            Return Me.IsNull(Me.tableremedios.tipoColumn)
        End Function
        
        Public Sub SettipoNull()
            Me(Me.tableremedios.tipoColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class remediosRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As remediosRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As remediosRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As remediosRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
