<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressSuggest
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.TB_Address = New System.Windows.Forms.TextBox()
		Me.B_Suggest = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Fias = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ResultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PostalcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CountryisocodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FederaldistrictDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RegionfiasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RegionkladridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RegionisocodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RegionwithtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RegiontypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RegiontypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AreafiasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AreakladridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AreawithtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AreatypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AreatypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CityfiasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitykladridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitywithtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitytypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitytypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CityareaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitydistrictfiasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitydistrictkladridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitydistrictwithtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitydistricttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitydistricttypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CitydistrictDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SettlementfiasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SettlementkladridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SettlementwithtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SettlementtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SettlementtypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SettlementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StreetfiasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StreetkladridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StreetwithtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StreettypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StreettypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HousefiasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HousekladridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HousewithtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HousetypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HousetypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HouseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BlocktypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BlocktypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BlockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlattypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlattypefullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlatareaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SquaremeterpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FlatpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PostalboxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FiasidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FiascodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FiaslevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FiasactualitystateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.KladridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CapitalmarkerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OkatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OktmoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TaxofficeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TaxofficelegalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TimezoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GeolatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GeolonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BeltwayhitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BeltwaydistanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QcgeoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QccompleteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QchouseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UnparsedpartsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StructuretypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DGV_Suggests = New System.Windows.Forms.DataGridView()
		Me.Button_ = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.Address_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.fias_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DGV_Suggests, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TB_Address
		'
		Me.TB_Address.Location = New System.Drawing.Point(12, 54)
		Me.TB_Address.Name = "TB_Address"
		Me.TB_Address.Size = New System.Drawing.Size(776, 20)
		Me.TB_Address.TabIndex = 1
		'
		'B_Suggest
		'
		Me.B_Suggest.Location = New System.Drawing.Point(713, 80)
		Me.B_Suggest.Name = "B_Suggest"
		Me.B_Suggest.Size = New System.Drawing.Size(75, 23)
		Me.B_Suggest.TabIndex = 2
		Me.B_Suggest.Text = "B_Suggest"
		Me.B_Suggest.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fias, Me.SourceDataGridViewTextBoxColumn, Me.ResultDataGridViewTextBoxColumn, Me.PostalcodeDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.CountryisocodeDataGridViewTextBoxColumn, Me.FederaldistrictDataGridViewTextBoxColumn, Me.RegionfiasidDataGridViewTextBoxColumn, Me.RegionkladridDataGridViewTextBoxColumn, Me.RegionisocodeDataGridViewTextBoxColumn, Me.RegionwithtypeDataGridViewTextBoxColumn, Me.RegiontypeDataGridViewTextBoxColumn, Me.RegiontypefullDataGridViewTextBoxColumn, Me.RegionDataGridViewTextBoxColumn, Me.AreafiasidDataGridViewTextBoxColumn, Me.AreakladridDataGridViewTextBoxColumn, Me.AreawithtypeDataGridViewTextBoxColumn, Me.AreatypeDataGridViewTextBoxColumn, Me.AreatypefullDataGridViewTextBoxColumn, Me.AreaDataGridViewTextBoxColumn, Me.CityfiasidDataGridViewTextBoxColumn, Me.CitykladridDataGridViewTextBoxColumn, Me.CitywithtypeDataGridViewTextBoxColumn, Me.CitytypeDataGridViewTextBoxColumn, Me.CitytypefullDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.CityareaDataGridViewTextBoxColumn, Me.CitydistrictfiasidDataGridViewTextBoxColumn, Me.CitydistrictkladridDataGridViewTextBoxColumn, Me.CitydistrictwithtypeDataGridViewTextBoxColumn, Me.CitydistricttypeDataGridViewTextBoxColumn, Me.CitydistricttypefullDataGridViewTextBoxColumn, Me.CitydistrictDataGridViewTextBoxColumn, Me.SettlementfiasidDataGridViewTextBoxColumn, Me.SettlementkladridDataGridViewTextBoxColumn, Me.SettlementwithtypeDataGridViewTextBoxColumn, Me.SettlementtypeDataGridViewTextBoxColumn, Me.SettlementtypefullDataGridViewTextBoxColumn, Me.SettlementDataGridViewTextBoxColumn, Me.StreetfiasidDataGridViewTextBoxColumn, Me.StreetkladridDataGridViewTextBoxColumn, Me.StreetwithtypeDataGridViewTextBoxColumn, Me.StreettypeDataGridViewTextBoxColumn, Me.StreettypefullDataGridViewTextBoxColumn, Me.StreetDataGridViewTextBoxColumn, Me.HousefiasidDataGridViewTextBoxColumn, Me.HousekladridDataGridViewTextBoxColumn, Me.HousewithtypeDataGridViewTextBoxColumn, Me.HousetypeDataGridViewTextBoxColumn, Me.HousetypefullDataGridViewTextBoxColumn, Me.HouseDataGridViewTextBoxColumn, Me.BlocktypeDataGridViewTextBoxColumn, Me.BlocktypefullDataGridViewTextBoxColumn, Me.BlockDataGridViewTextBoxColumn, Me.FlattypeDataGridViewTextBoxColumn, Me.FlattypefullDataGridViewTextBoxColumn, Me.FlatDataGridViewTextBoxColumn, Me.FlatareaDataGridViewTextBoxColumn, Me.SquaremeterpriceDataGridViewTextBoxColumn, Me.FlatpriceDataGridViewTextBoxColumn, Me.PostalboxDataGridViewTextBoxColumn, Me.FiasidDataGridViewTextBoxColumn, Me.FiascodeDataGridViewTextBoxColumn, Me.FiaslevelDataGridViewTextBoxColumn, Me.FiasactualitystateDataGridViewTextBoxColumn, Me.KladridDataGridViewTextBoxColumn, Me.CapitalmarkerDataGridViewTextBoxColumn, Me.OkatoDataGridViewTextBoxColumn, Me.OktmoDataGridViewTextBoxColumn, Me.TaxofficeDataGridViewTextBoxColumn, Me.TaxofficelegalDataGridViewTextBoxColumn, Me.TimezoneDataGridViewTextBoxColumn, Me.GeolatDataGridViewTextBoxColumn, Me.GeolonDataGridViewTextBoxColumn, Me.BeltwayhitDataGridViewTextBoxColumn, Me.BeltwaydistanceDataGridViewTextBoxColumn, Me.QcgeoDataGridViewTextBoxColumn, Me.QccompleteDataGridViewTextBoxColumn, Me.QchouseDataGridViewTextBoxColumn, Me.QcDataGridViewTextBoxColumn, Me.UnparsedpartsDataGridViewTextBoxColumn, Me.StructuretypeDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.AddressBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(12, 289)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(580, 167)
		Me.DataGridView1.TabIndex = 3
		'
		'Fias
		'
		Me.Fias.HeaderText = "fias"
		Me.Fias.Name = "Fias"
		'
		'SourceDataGridViewTextBoxColumn
		'
		Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "source"
		Me.SourceDataGridViewTextBoxColumn.HeaderText = "source"
		Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
		'
		'ResultDataGridViewTextBoxColumn
		'
		Me.ResultDataGridViewTextBoxColumn.DataPropertyName = "result"
		Me.ResultDataGridViewTextBoxColumn.HeaderText = "result"
		Me.ResultDataGridViewTextBoxColumn.Name = "ResultDataGridViewTextBoxColumn"
		'
		'PostalcodeDataGridViewTextBoxColumn
		'
		Me.PostalcodeDataGridViewTextBoxColumn.DataPropertyName = "postal_code"
		Me.PostalcodeDataGridViewTextBoxColumn.HeaderText = "postal_code"
		Me.PostalcodeDataGridViewTextBoxColumn.Name = "PostalcodeDataGridViewTextBoxColumn"
		'
		'CountryDataGridViewTextBoxColumn
		'
		Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "country"
		Me.CountryDataGridViewTextBoxColumn.HeaderText = "country"
		Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
		'
		'CountryisocodeDataGridViewTextBoxColumn
		'
		Me.CountryisocodeDataGridViewTextBoxColumn.DataPropertyName = "country_iso_code"
		Me.CountryisocodeDataGridViewTextBoxColumn.HeaderText = "country_iso_code"
		Me.CountryisocodeDataGridViewTextBoxColumn.Name = "CountryisocodeDataGridViewTextBoxColumn"
		'
		'FederaldistrictDataGridViewTextBoxColumn
		'
		Me.FederaldistrictDataGridViewTextBoxColumn.DataPropertyName = "federal_district"
		Me.FederaldistrictDataGridViewTextBoxColumn.HeaderText = "federal_district"
		Me.FederaldistrictDataGridViewTextBoxColumn.Name = "FederaldistrictDataGridViewTextBoxColumn"
		'
		'RegionfiasidDataGridViewTextBoxColumn
		'
		Me.RegionfiasidDataGridViewTextBoxColumn.DataPropertyName = "region_fias_id"
		Me.RegionfiasidDataGridViewTextBoxColumn.HeaderText = "region_fias_id"
		Me.RegionfiasidDataGridViewTextBoxColumn.Name = "RegionfiasidDataGridViewTextBoxColumn"
		'
		'RegionkladridDataGridViewTextBoxColumn
		'
		Me.RegionkladridDataGridViewTextBoxColumn.DataPropertyName = "region_kladr_id"
		Me.RegionkladridDataGridViewTextBoxColumn.HeaderText = "region_kladr_id"
		Me.RegionkladridDataGridViewTextBoxColumn.Name = "RegionkladridDataGridViewTextBoxColumn"
		'
		'RegionisocodeDataGridViewTextBoxColumn
		'
		Me.RegionisocodeDataGridViewTextBoxColumn.DataPropertyName = "region_iso_code"
		Me.RegionisocodeDataGridViewTextBoxColumn.HeaderText = "region_iso_code"
		Me.RegionisocodeDataGridViewTextBoxColumn.Name = "RegionisocodeDataGridViewTextBoxColumn"
		'
		'RegionwithtypeDataGridViewTextBoxColumn
		'
		Me.RegionwithtypeDataGridViewTextBoxColumn.DataPropertyName = "region_with_type"
		Me.RegionwithtypeDataGridViewTextBoxColumn.HeaderText = "region_with_type"
		Me.RegionwithtypeDataGridViewTextBoxColumn.Name = "RegionwithtypeDataGridViewTextBoxColumn"
		'
		'RegiontypeDataGridViewTextBoxColumn
		'
		Me.RegiontypeDataGridViewTextBoxColumn.DataPropertyName = "region_type"
		Me.RegiontypeDataGridViewTextBoxColumn.HeaderText = "region_type"
		Me.RegiontypeDataGridViewTextBoxColumn.Name = "RegiontypeDataGridViewTextBoxColumn"
		'
		'RegiontypefullDataGridViewTextBoxColumn
		'
		Me.RegiontypefullDataGridViewTextBoxColumn.DataPropertyName = "region_type_full"
		Me.RegiontypefullDataGridViewTextBoxColumn.HeaderText = "region_type_full"
		Me.RegiontypefullDataGridViewTextBoxColumn.Name = "RegiontypefullDataGridViewTextBoxColumn"
		'
		'RegionDataGridViewTextBoxColumn
		'
		Me.RegionDataGridViewTextBoxColumn.DataPropertyName = "region"
		Me.RegionDataGridViewTextBoxColumn.HeaderText = "region"
		Me.RegionDataGridViewTextBoxColumn.Name = "RegionDataGridViewTextBoxColumn"
		'
		'AreafiasidDataGridViewTextBoxColumn
		'
		Me.AreafiasidDataGridViewTextBoxColumn.DataPropertyName = "area_fias_id"
		Me.AreafiasidDataGridViewTextBoxColumn.HeaderText = "area_fias_id"
		Me.AreafiasidDataGridViewTextBoxColumn.Name = "AreafiasidDataGridViewTextBoxColumn"
		'
		'AreakladridDataGridViewTextBoxColumn
		'
		Me.AreakladridDataGridViewTextBoxColumn.DataPropertyName = "area_kladr_id"
		Me.AreakladridDataGridViewTextBoxColumn.HeaderText = "area_kladr_id"
		Me.AreakladridDataGridViewTextBoxColumn.Name = "AreakladridDataGridViewTextBoxColumn"
		'
		'AreawithtypeDataGridViewTextBoxColumn
		'
		Me.AreawithtypeDataGridViewTextBoxColumn.DataPropertyName = "area_with_type"
		Me.AreawithtypeDataGridViewTextBoxColumn.HeaderText = "area_with_type"
		Me.AreawithtypeDataGridViewTextBoxColumn.Name = "AreawithtypeDataGridViewTextBoxColumn"
		'
		'AreatypeDataGridViewTextBoxColumn
		'
		Me.AreatypeDataGridViewTextBoxColumn.DataPropertyName = "area_type"
		Me.AreatypeDataGridViewTextBoxColumn.HeaderText = "area_type"
		Me.AreatypeDataGridViewTextBoxColumn.Name = "AreatypeDataGridViewTextBoxColumn"
		'
		'AreatypefullDataGridViewTextBoxColumn
		'
		Me.AreatypefullDataGridViewTextBoxColumn.DataPropertyName = "area_type_full"
		Me.AreatypefullDataGridViewTextBoxColumn.HeaderText = "area_type_full"
		Me.AreatypefullDataGridViewTextBoxColumn.Name = "AreatypefullDataGridViewTextBoxColumn"
		'
		'AreaDataGridViewTextBoxColumn
		'
		Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "area"
		Me.AreaDataGridViewTextBoxColumn.HeaderText = "area"
		Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
		'
		'CityfiasidDataGridViewTextBoxColumn
		'
		Me.CityfiasidDataGridViewTextBoxColumn.DataPropertyName = "city_fias_id"
		Me.CityfiasidDataGridViewTextBoxColumn.HeaderText = "city_fias_id"
		Me.CityfiasidDataGridViewTextBoxColumn.Name = "CityfiasidDataGridViewTextBoxColumn"
		'
		'CitykladridDataGridViewTextBoxColumn
		'
		Me.CitykladridDataGridViewTextBoxColumn.DataPropertyName = "city_kladr_id"
		Me.CitykladridDataGridViewTextBoxColumn.HeaderText = "city_kladr_id"
		Me.CitykladridDataGridViewTextBoxColumn.Name = "CitykladridDataGridViewTextBoxColumn"
		'
		'CitywithtypeDataGridViewTextBoxColumn
		'
		Me.CitywithtypeDataGridViewTextBoxColumn.DataPropertyName = "city_with_type"
		Me.CitywithtypeDataGridViewTextBoxColumn.HeaderText = "city_with_type"
		Me.CitywithtypeDataGridViewTextBoxColumn.Name = "CitywithtypeDataGridViewTextBoxColumn"
		'
		'CitytypeDataGridViewTextBoxColumn
		'
		Me.CitytypeDataGridViewTextBoxColumn.DataPropertyName = "city_type"
		Me.CitytypeDataGridViewTextBoxColumn.HeaderText = "city_type"
		Me.CitytypeDataGridViewTextBoxColumn.Name = "CitytypeDataGridViewTextBoxColumn"
		'
		'CitytypefullDataGridViewTextBoxColumn
		'
		Me.CitytypefullDataGridViewTextBoxColumn.DataPropertyName = "city_type_full"
		Me.CitytypefullDataGridViewTextBoxColumn.HeaderText = "city_type_full"
		Me.CitytypefullDataGridViewTextBoxColumn.Name = "CitytypefullDataGridViewTextBoxColumn"
		'
		'CityDataGridViewTextBoxColumn
		'
		Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
		Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
		Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
		'
		'CityareaDataGridViewTextBoxColumn
		'
		Me.CityareaDataGridViewTextBoxColumn.DataPropertyName = "city_area"
		Me.CityareaDataGridViewTextBoxColumn.HeaderText = "city_area"
		Me.CityareaDataGridViewTextBoxColumn.Name = "CityareaDataGridViewTextBoxColumn"
		'
		'CitydistrictfiasidDataGridViewTextBoxColumn
		'
		Me.CitydistrictfiasidDataGridViewTextBoxColumn.DataPropertyName = "city_district_fias_id"
		Me.CitydistrictfiasidDataGridViewTextBoxColumn.HeaderText = "city_district_fias_id"
		Me.CitydistrictfiasidDataGridViewTextBoxColumn.Name = "CitydistrictfiasidDataGridViewTextBoxColumn"
		'
		'CitydistrictkladridDataGridViewTextBoxColumn
		'
		Me.CitydistrictkladridDataGridViewTextBoxColumn.DataPropertyName = "city_district_kladr_id"
		Me.CitydistrictkladridDataGridViewTextBoxColumn.HeaderText = "city_district_kladr_id"
		Me.CitydistrictkladridDataGridViewTextBoxColumn.Name = "CitydistrictkladridDataGridViewTextBoxColumn"
		'
		'CitydistrictwithtypeDataGridViewTextBoxColumn
		'
		Me.CitydistrictwithtypeDataGridViewTextBoxColumn.DataPropertyName = "city_district_with_type"
		Me.CitydistrictwithtypeDataGridViewTextBoxColumn.HeaderText = "city_district_with_type"
		Me.CitydistrictwithtypeDataGridViewTextBoxColumn.Name = "CitydistrictwithtypeDataGridViewTextBoxColumn"
		'
		'CitydistricttypeDataGridViewTextBoxColumn
		'
		Me.CitydistricttypeDataGridViewTextBoxColumn.DataPropertyName = "city_district_type"
		Me.CitydistricttypeDataGridViewTextBoxColumn.HeaderText = "city_district_type"
		Me.CitydistricttypeDataGridViewTextBoxColumn.Name = "CitydistricttypeDataGridViewTextBoxColumn"
		'
		'CitydistricttypefullDataGridViewTextBoxColumn
		'
		Me.CitydistricttypefullDataGridViewTextBoxColumn.DataPropertyName = "city_district_type_full"
		Me.CitydistricttypefullDataGridViewTextBoxColumn.HeaderText = "city_district_type_full"
		Me.CitydistricttypefullDataGridViewTextBoxColumn.Name = "CitydistricttypefullDataGridViewTextBoxColumn"
		'
		'CitydistrictDataGridViewTextBoxColumn
		'
		Me.CitydistrictDataGridViewTextBoxColumn.DataPropertyName = "city_district"
		Me.CitydistrictDataGridViewTextBoxColumn.HeaderText = "city_district"
		Me.CitydistrictDataGridViewTextBoxColumn.Name = "CitydistrictDataGridViewTextBoxColumn"
		'
		'SettlementfiasidDataGridViewTextBoxColumn
		'
		Me.SettlementfiasidDataGridViewTextBoxColumn.DataPropertyName = "settlement_fias_id"
		Me.SettlementfiasidDataGridViewTextBoxColumn.HeaderText = "settlement_fias_id"
		Me.SettlementfiasidDataGridViewTextBoxColumn.Name = "SettlementfiasidDataGridViewTextBoxColumn"
		'
		'SettlementkladridDataGridViewTextBoxColumn
		'
		Me.SettlementkladridDataGridViewTextBoxColumn.DataPropertyName = "settlement_kladr_id"
		Me.SettlementkladridDataGridViewTextBoxColumn.HeaderText = "settlement_kladr_id"
		Me.SettlementkladridDataGridViewTextBoxColumn.Name = "SettlementkladridDataGridViewTextBoxColumn"
		'
		'SettlementwithtypeDataGridViewTextBoxColumn
		'
		Me.SettlementwithtypeDataGridViewTextBoxColumn.DataPropertyName = "settlement_with_type"
		Me.SettlementwithtypeDataGridViewTextBoxColumn.HeaderText = "settlement_with_type"
		Me.SettlementwithtypeDataGridViewTextBoxColumn.Name = "SettlementwithtypeDataGridViewTextBoxColumn"
		'
		'SettlementtypeDataGridViewTextBoxColumn
		'
		Me.SettlementtypeDataGridViewTextBoxColumn.DataPropertyName = "settlement_type"
		Me.SettlementtypeDataGridViewTextBoxColumn.HeaderText = "settlement_type"
		Me.SettlementtypeDataGridViewTextBoxColumn.Name = "SettlementtypeDataGridViewTextBoxColumn"
		'
		'SettlementtypefullDataGridViewTextBoxColumn
		'
		Me.SettlementtypefullDataGridViewTextBoxColumn.DataPropertyName = "settlement_type_full"
		Me.SettlementtypefullDataGridViewTextBoxColumn.HeaderText = "settlement_type_full"
		Me.SettlementtypefullDataGridViewTextBoxColumn.Name = "SettlementtypefullDataGridViewTextBoxColumn"
		'
		'SettlementDataGridViewTextBoxColumn
		'
		Me.SettlementDataGridViewTextBoxColumn.DataPropertyName = "settlement"
		Me.SettlementDataGridViewTextBoxColumn.HeaderText = "settlement"
		Me.SettlementDataGridViewTextBoxColumn.Name = "SettlementDataGridViewTextBoxColumn"
		'
		'StreetfiasidDataGridViewTextBoxColumn
		'
		Me.StreetfiasidDataGridViewTextBoxColumn.DataPropertyName = "street_fias_id"
		Me.StreetfiasidDataGridViewTextBoxColumn.HeaderText = "street_fias_id"
		Me.StreetfiasidDataGridViewTextBoxColumn.Name = "StreetfiasidDataGridViewTextBoxColumn"
		'
		'StreetkladridDataGridViewTextBoxColumn
		'
		Me.StreetkladridDataGridViewTextBoxColumn.DataPropertyName = "street_kladr_id"
		Me.StreetkladridDataGridViewTextBoxColumn.HeaderText = "street_kladr_id"
		Me.StreetkladridDataGridViewTextBoxColumn.Name = "StreetkladridDataGridViewTextBoxColumn"
		'
		'StreetwithtypeDataGridViewTextBoxColumn
		'
		Me.StreetwithtypeDataGridViewTextBoxColumn.DataPropertyName = "street_with_type"
		Me.StreetwithtypeDataGridViewTextBoxColumn.HeaderText = "street_with_type"
		Me.StreetwithtypeDataGridViewTextBoxColumn.Name = "StreetwithtypeDataGridViewTextBoxColumn"
		'
		'StreettypeDataGridViewTextBoxColumn
		'
		Me.StreettypeDataGridViewTextBoxColumn.DataPropertyName = "street_type"
		Me.StreettypeDataGridViewTextBoxColumn.HeaderText = "street_type"
		Me.StreettypeDataGridViewTextBoxColumn.Name = "StreettypeDataGridViewTextBoxColumn"
		'
		'StreettypefullDataGridViewTextBoxColumn
		'
		Me.StreettypefullDataGridViewTextBoxColumn.DataPropertyName = "street_type_full"
		Me.StreettypefullDataGridViewTextBoxColumn.HeaderText = "street_type_full"
		Me.StreettypefullDataGridViewTextBoxColumn.Name = "StreettypefullDataGridViewTextBoxColumn"
		'
		'StreetDataGridViewTextBoxColumn
		'
		Me.StreetDataGridViewTextBoxColumn.DataPropertyName = "street"
		Me.StreetDataGridViewTextBoxColumn.HeaderText = "street"
		Me.StreetDataGridViewTextBoxColumn.Name = "StreetDataGridViewTextBoxColumn"
		'
		'HousefiasidDataGridViewTextBoxColumn
		'
		Me.HousefiasidDataGridViewTextBoxColumn.DataPropertyName = "house_fias_id"
		Me.HousefiasidDataGridViewTextBoxColumn.HeaderText = "house_fias_id"
		Me.HousefiasidDataGridViewTextBoxColumn.Name = "HousefiasidDataGridViewTextBoxColumn"
		'
		'HousekladridDataGridViewTextBoxColumn
		'
		Me.HousekladridDataGridViewTextBoxColumn.DataPropertyName = "house_kladr_id"
		Me.HousekladridDataGridViewTextBoxColumn.HeaderText = "house_kladr_id"
		Me.HousekladridDataGridViewTextBoxColumn.Name = "HousekladridDataGridViewTextBoxColumn"
		'
		'HousewithtypeDataGridViewTextBoxColumn
		'
		Me.HousewithtypeDataGridViewTextBoxColumn.DataPropertyName = "house_with_type"
		Me.HousewithtypeDataGridViewTextBoxColumn.HeaderText = "house_with_type"
		Me.HousewithtypeDataGridViewTextBoxColumn.Name = "HousewithtypeDataGridViewTextBoxColumn"
		'
		'HousetypeDataGridViewTextBoxColumn
		'
		Me.HousetypeDataGridViewTextBoxColumn.DataPropertyName = "house_type"
		Me.HousetypeDataGridViewTextBoxColumn.HeaderText = "house_type"
		Me.HousetypeDataGridViewTextBoxColumn.Name = "HousetypeDataGridViewTextBoxColumn"
		'
		'HousetypefullDataGridViewTextBoxColumn
		'
		Me.HousetypefullDataGridViewTextBoxColumn.DataPropertyName = "house_type_full"
		Me.HousetypefullDataGridViewTextBoxColumn.HeaderText = "house_type_full"
		Me.HousetypefullDataGridViewTextBoxColumn.Name = "HousetypefullDataGridViewTextBoxColumn"
		'
		'HouseDataGridViewTextBoxColumn
		'
		Me.HouseDataGridViewTextBoxColumn.DataPropertyName = "house"
		Me.HouseDataGridViewTextBoxColumn.HeaderText = "house"
		Me.HouseDataGridViewTextBoxColumn.Name = "HouseDataGridViewTextBoxColumn"
		'
		'BlocktypeDataGridViewTextBoxColumn
		'
		Me.BlocktypeDataGridViewTextBoxColumn.DataPropertyName = "block_type"
		Me.BlocktypeDataGridViewTextBoxColumn.HeaderText = "block_type"
		Me.BlocktypeDataGridViewTextBoxColumn.Name = "BlocktypeDataGridViewTextBoxColumn"
		'
		'BlocktypefullDataGridViewTextBoxColumn
		'
		Me.BlocktypefullDataGridViewTextBoxColumn.DataPropertyName = "block_type_full"
		Me.BlocktypefullDataGridViewTextBoxColumn.HeaderText = "block_type_full"
		Me.BlocktypefullDataGridViewTextBoxColumn.Name = "BlocktypefullDataGridViewTextBoxColumn"
		'
		'BlockDataGridViewTextBoxColumn
		'
		Me.BlockDataGridViewTextBoxColumn.DataPropertyName = "block"
		Me.BlockDataGridViewTextBoxColumn.HeaderText = "block"
		Me.BlockDataGridViewTextBoxColumn.Name = "BlockDataGridViewTextBoxColumn"
		'
		'FlattypeDataGridViewTextBoxColumn
		'
		Me.FlattypeDataGridViewTextBoxColumn.DataPropertyName = "flat_type"
		Me.FlattypeDataGridViewTextBoxColumn.HeaderText = "flat_type"
		Me.FlattypeDataGridViewTextBoxColumn.Name = "FlattypeDataGridViewTextBoxColumn"
		'
		'FlattypefullDataGridViewTextBoxColumn
		'
		Me.FlattypefullDataGridViewTextBoxColumn.DataPropertyName = "flat_type_full"
		Me.FlattypefullDataGridViewTextBoxColumn.HeaderText = "flat_type_full"
		Me.FlattypefullDataGridViewTextBoxColumn.Name = "FlattypefullDataGridViewTextBoxColumn"
		'
		'FlatDataGridViewTextBoxColumn
		'
		Me.FlatDataGridViewTextBoxColumn.DataPropertyName = "flat"
		Me.FlatDataGridViewTextBoxColumn.HeaderText = "flat"
		Me.FlatDataGridViewTextBoxColumn.Name = "FlatDataGridViewTextBoxColumn"
		'
		'FlatareaDataGridViewTextBoxColumn
		'
		Me.FlatareaDataGridViewTextBoxColumn.DataPropertyName = "flat_area"
		Me.FlatareaDataGridViewTextBoxColumn.HeaderText = "flat_area"
		Me.FlatareaDataGridViewTextBoxColumn.Name = "FlatareaDataGridViewTextBoxColumn"
		'
		'SquaremeterpriceDataGridViewTextBoxColumn
		'
		Me.SquaremeterpriceDataGridViewTextBoxColumn.DataPropertyName = "square_meter_price"
		Me.SquaremeterpriceDataGridViewTextBoxColumn.HeaderText = "square_meter_price"
		Me.SquaremeterpriceDataGridViewTextBoxColumn.Name = "SquaremeterpriceDataGridViewTextBoxColumn"
		'
		'FlatpriceDataGridViewTextBoxColumn
		'
		Me.FlatpriceDataGridViewTextBoxColumn.DataPropertyName = "flat_price"
		Me.FlatpriceDataGridViewTextBoxColumn.HeaderText = "flat_price"
		Me.FlatpriceDataGridViewTextBoxColumn.Name = "FlatpriceDataGridViewTextBoxColumn"
		'
		'PostalboxDataGridViewTextBoxColumn
		'
		Me.PostalboxDataGridViewTextBoxColumn.DataPropertyName = "postal_box"
		Me.PostalboxDataGridViewTextBoxColumn.HeaderText = "postal_box"
		Me.PostalboxDataGridViewTextBoxColumn.Name = "PostalboxDataGridViewTextBoxColumn"
		'
		'FiasidDataGridViewTextBoxColumn
		'
		Me.FiasidDataGridViewTextBoxColumn.DataPropertyName = "fias_id"
		Me.FiasidDataGridViewTextBoxColumn.HeaderText = "fias_id"
		Me.FiasidDataGridViewTextBoxColumn.Name = "FiasidDataGridViewTextBoxColumn"
		'
		'FiascodeDataGridViewTextBoxColumn
		'
		Me.FiascodeDataGridViewTextBoxColumn.DataPropertyName = "fias_code"
		Me.FiascodeDataGridViewTextBoxColumn.HeaderText = "fias_code"
		Me.FiascodeDataGridViewTextBoxColumn.Name = "FiascodeDataGridViewTextBoxColumn"
		'
		'FiaslevelDataGridViewTextBoxColumn
		'
		Me.FiaslevelDataGridViewTextBoxColumn.DataPropertyName = "fias_level"
		Me.FiaslevelDataGridViewTextBoxColumn.HeaderText = "fias_level"
		Me.FiaslevelDataGridViewTextBoxColumn.Name = "FiaslevelDataGridViewTextBoxColumn"
		'
		'FiasactualitystateDataGridViewTextBoxColumn
		'
		Me.FiasactualitystateDataGridViewTextBoxColumn.DataPropertyName = "fias_actuality_state"
		Me.FiasactualitystateDataGridViewTextBoxColumn.HeaderText = "fias_actuality_state"
		Me.FiasactualitystateDataGridViewTextBoxColumn.Name = "FiasactualitystateDataGridViewTextBoxColumn"
		'
		'KladridDataGridViewTextBoxColumn
		'
		Me.KladridDataGridViewTextBoxColumn.DataPropertyName = "kladr_id"
		Me.KladridDataGridViewTextBoxColumn.HeaderText = "kladr_id"
		Me.KladridDataGridViewTextBoxColumn.Name = "KladridDataGridViewTextBoxColumn"
		'
		'CapitalmarkerDataGridViewTextBoxColumn
		'
		Me.CapitalmarkerDataGridViewTextBoxColumn.DataPropertyName = "capital_marker"
		Me.CapitalmarkerDataGridViewTextBoxColumn.HeaderText = "capital_marker"
		Me.CapitalmarkerDataGridViewTextBoxColumn.Name = "CapitalmarkerDataGridViewTextBoxColumn"
		'
		'OkatoDataGridViewTextBoxColumn
		'
		Me.OkatoDataGridViewTextBoxColumn.DataPropertyName = "okato"
		Me.OkatoDataGridViewTextBoxColumn.HeaderText = "okato"
		Me.OkatoDataGridViewTextBoxColumn.Name = "OkatoDataGridViewTextBoxColumn"
		'
		'OktmoDataGridViewTextBoxColumn
		'
		Me.OktmoDataGridViewTextBoxColumn.DataPropertyName = "oktmo"
		Me.OktmoDataGridViewTextBoxColumn.HeaderText = "oktmo"
		Me.OktmoDataGridViewTextBoxColumn.Name = "OktmoDataGridViewTextBoxColumn"
		'
		'TaxofficeDataGridViewTextBoxColumn
		'
		Me.TaxofficeDataGridViewTextBoxColumn.DataPropertyName = "tax_office"
		Me.TaxofficeDataGridViewTextBoxColumn.HeaderText = "tax_office"
		Me.TaxofficeDataGridViewTextBoxColumn.Name = "TaxofficeDataGridViewTextBoxColumn"
		'
		'TaxofficelegalDataGridViewTextBoxColumn
		'
		Me.TaxofficelegalDataGridViewTextBoxColumn.DataPropertyName = "tax_office_legal"
		Me.TaxofficelegalDataGridViewTextBoxColumn.HeaderText = "tax_office_legal"
		Me.TaxofficelegalDataGridViewTextBoxColumn.Name = "TaxofficelegalDataGridViewTextBoxColumn"
		'
		'TimezoneDataGridViewTextBoxColumn
		'
		Me.TimezoneDataGridViewTextBoxColumn.DataPropertyName = "timezone"
		Me.TimezoneDataGridViewTextBoxColumn.HeaderText = "timezone"
		Me.TimezoneDataGridViewTextBoxColumn.Name = "TimezoneDataGridViewTextBoxColumn"
		'
		'GeolatDataGridViewTextBoxColumn
		'
		Me.GeolatDataGridViewTextBoxColumn.DataPropertyName = "geo_lat"
		Me.GeolatDataGridViewTextBoxColumn.HeaderText = "geo_lat"
		Me.GeolatDataGridViewTextBoxColumn.Name = "GeolatDataGridViewTextBoxColumn"
		'
		'GeolonDataGridViewTextBoxColumn
		'
		Me.GeolonDataGridViewTextBoxColumn.DataPropertyName = "geo_lon"
		Me.GeolonDataGridViewTextBoxColumn.HeaderText = "geo_lon"
		Me.GeolonDataGridViewTextBoxColumn.Name = "GeolonDataGridViewTextBoxColumn"
		'
		'BeltwayhitDataGridViewTextBoxColumn
		'
		Me.BeltwayhitDataGridViewTextBoxColumn.DataPropertyName = "beltway_hit"
		Me.BeltwayhitDataGridViewTextBoxColumn.HeaderText = "beltway_hit"
		Me.BeltwayhitDataGridViewTextBoxColumn.Name = "BeltwayhitDataGridViewTextBoxColumn"
		'
		'BeltwaydistanceDataGridViewTextBoxColumn
		'
		Me.BeltwaydistanceDataGridViewTextBoxColumn.DataPropertyName = "beltway_distance"
		Me.BeltwaydistanceDataGridViewTextBoxColumn.HeaderText = "beltway_distance"
		Me.BeltwaydistanceDataGridViewTextBoxColumn.Name = "BeltwaydistanceDataGridViewTextBoxColumn"
		'
		'QcgeoDataGridViewTextBoxColumn
		'
		Me.QcgeoDataGridViewTextBoxColumn.DataPropertyName = "qc_geo"
		Me.QcgeoDataGridViewTextBoxColumn.HeaderText = "qc_geo"
		Me.QcgeoDataGridViewTextBoxColumn.Name = "QcgeoDataGridViewTextBoxColumn"
		'
		'QccompleteDataGridViewTextBoxColumn
		'
		Me.QccompleteDataGridViewTextBoxColumn.DataPropertyName = "qc_complete"
		Me.QccompleteDataGridViewTextBoxColumn.HeaderText = "qc_complete"
		Me.QccompleteDataGridViewTextBoxColumn.Name = "QccompleteDataGridViewTextBoxColumn"
		'
		'QchouseDataGridViewTextBoxColumn
		'
		Me.QchouseDataGridViewTextBoxColumn.DataPropertyName = "qc_house"
		Me.QchouseDataGridViewTextBoxColumn.HeaderText = "qc_house"
		Me.QchouseDataGridViewTextBoxColumn.Name = "QchouseDataGridViewTextBoxColumn"
		'
		'QcDataGridViewTextBoxColumn
		'
		Me.QcDataGridViewTextBoxColumn.DataPropertyName = "qc"
		Me.QcDataGridViewTextBoxColumn.HeaderText = "qc"
		Me.QcDataGridViewTextBoxColumn.Name = "QcDataGridViewTextBoxColumn"
		'
		'UnparsedpartsDataGridViewTextBoxColumn
		'
		Me.UnparsedpartsDataGridViewTextBoxColumn.DataPropertyName = "unparsed_parts"
		Me.UnparsedpartsDataGridViewTextBoxColumn.HeaderText = "unparsed_parts"
		Me.UnparsedpartsDataGridViewTextBoxColumn.Name = "UnparsedpartsDataGridViewTextBoxColumn"
		'
		'StructuretypeDataGridViewTextBoxColumn
		'
		Me.StructuretypeDataGridViewTextBoxColumn.DataPropertyName = "structure_type"
		Me.StructuretypeDataGridViewTextBoxColumn.HeaderText = "structure_type"
		Me.StructuretypeDataGridViewTextBoxColumn.Name = "StructuretypeDataGridViewTextBoxColumn"
		Me.StructuretypeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'AddressBindingSource
		'
		Me.AddressBindingSource.DataSource = GetType(Dadata.Model.Address)
		'
		'DGV_Suggests
		'
		Me.DGV_Suggests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV_Suggests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Button_, Me.Address_, Me.fias_})
		Me.DGV_Suggests.Location = New System.Drawing.Point(12, 80)
		Me.DGV_Suggests.MultiSelect = False
		Me.DGV_Suggests.Name = "DGV_Suggests"
		Me.DGV_Suggests.ReadOnly = True
		Me.DGV_Suggests.Size = New System.Drawing.Size(580, 150)
		Me.DGV_Suggests.TabIndex = 4
		'
		'Button_
		'
		Me.Button_.HeaderText = ""
		Me.Button_.Name = "Button_"
		Me.Button_.ReadOnly = True
		Me.Button_.Text = "Выбрать"
		'
		'Address_
		'
		Me.Address_.DataPropertyName = "value"
		Me.Address_.HeaderText = "Адрес"
		Me.Address_.Name = "Address_"
		Me.Address_.ReadOnly = True
		'
		'fias_
		'
		Me.fias_.DataPropertyName = "data.fias_id"
		Me.fias_.HeaderText = "ФИАС"
		Me.fias_.Name = "fias_"
		Me.fias_.ReadOnly = True
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(362, 21)
		Me.ComboBox1.TabIndex = 5
		'
		'AddressSuggest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(801, 468)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.DGV_Suggests)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.B_Suggest)
		Me.Controls.Add(Me.TB_Address)
		Me.Name = "AddressSuggest"
		Me.Text = "AddressSuggest"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DGV_Suggests, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TB_Address As TextBox
    Friend WithEvents B_Suggest As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AddressBindingSource As BindingSource
    Friend WithEvents Fias As DataGridViewTextBoxColumn
    Friend WithEvents SourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryisocodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FederaldistrictDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionfiasidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionkladridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionisocodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionwithtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegiontypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegiontypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreafiasidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreakladridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreawithtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreatypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreatypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityfiasidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitykladridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitywithtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitytypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitytypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityareaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitydistrictfiasidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitydistrictkladridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitydistrictwithtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitydistricttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitydistricttypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CitydistrictDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SettlementfiasidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SettlementkladridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SettlementwithtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SettlementtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SettlementtypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SettlementDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetfiasidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetkladridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetwithtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreettypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreettypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HousefiasidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HousekladridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HousewithtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HousetypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HousetypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlocktypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlocktypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlattypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlattypefullDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlatareaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SquaremeterpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlatpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalboxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiasidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiascodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiaslevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiasactualitystateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KladridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapitalmarkerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OkatoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OktmoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxofficeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxofficelegalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimezoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeolatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeolonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeltwayhitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeltwaydistanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QcgeoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QccompleteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QchouseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnparsedpartsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StructuretypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Suggests As DataGridView
    Friend WithEvents Button_ As DataGridViewButtonColumn
    Friend WithEvents Address_ As DataGridViewTextBoxColumn
    Friend WithEvents fias_ As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
End Class
