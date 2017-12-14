﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WebPPC.AcceptanceTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class FilterSearchFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Filter.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FilterSearch", "\tcho phep nguoi dung tim kiem du an theo Name, Price, Bedroom, Bathroom, Packing " +
                    "Place, Area", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "FilterSearch")))
            {
                global::WebPPC.AcceptanceTest.Features.FilterSearchFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ID",
                        "PropertyName",
                        "Avatar",
                        "Property_ID",
                        "Street_ID",
                        "Ward_ID",
                        "District_ID",
                        "Price",
                        "Area",
                        "Bedroom",
                        "Bathroom",
                        "PackingPlace",
                        "UserID"});
            table1.AddRow(new string[] {
                        "11",
                        "PIS Top Apartment",
                        "PIS_6656-Edit-stamp.jpg",
                        "1",
                        "748",
                        "2",
                        "2",
                        "10000",
                        "120m2",
                        "3",
                        "3",
                        "1",
                        "1"});
            table1.AddRow(new string[] {
                        "12",
                        "ICON 56 – Modern Style Apartment",
                        "PIS_7432-Edit-stamp.jpg",
                        "2",
                        "750",
                        "3",
                        "2",
                        "30000",
                        "130m2",
                        "2",
                        "4",
                        "1",
                        "1"});
            table1.AddRow(new string[] {
                        "13",
                        "PIS Serviced Apartment – Boho Style",
                        "PIS_4622-Edit.jpg",
                        "2",
                        "749",
                        "4",
                        "2",
                        "70000",
                        "120m2",
                        "3",
                        "2",
                        "1",
                        "1"});
            table1.AddRow(new string[] {
                        "14",
                        "Bigroom with Riverview",
                        "PIS_4622-Edit.jpg",
                        "3",
                        "752",
                        "5",
                        "2",
                        "90000",
                        "200m2",
                        "2",
                        "3",
                        "1",
                        "1"});
            table1.AddRow(new string[] {
                        "15",
                        "PIS Serviced Apartment – Style 3",
                        "PIS3611.jpg",
                        "3",
                        "755",
                        "33",
                        "3",
                        "30000",
                        "130m2",
                        "2",
                        "4",
                        "1",
                        "1"});
            table1.AddRow(new string[] {
                        "16",
                        "Vinhomes Central Park L2 – Duong’s Apartment",
                        "PIS_7389-Edit-stamp.jpg",
                        "2",
                        "756",
                        "34",
                        "3",
                        "110000",
                        "150m2",
                        "4",
                        "2",
                        "1",
                        "1"});
            table1.AddRow(new string[] {
                        "17",
                        "Saigon Pearl Ruby Block",
                        "PIS_7319-Edit-stamp.jpg",
                        "1",
                        "758",
                        "35",
                        "3",
                        "30000",
                        "130m2",
                        "3",
                        "3",
                        "1",
                        "1"});
            table1.AddRow(new string[] {
                        "18",
                        "Nguyen Dinh Chinh – Duplex with Balcony",
                        "PIS_6706-Edit-stamp.jpg",
                        "1",
                        "760",
                        "36",
                        "3",
                        "200000",
                        "120m2",
                        "3",
                        "2",
                        "2",
                        "1"});
            table1.AddRow(new string[] {
                        "19",
                        "Sunshine Ben Thanh",
                        "sunshine-benthanh-cityhome-10-stamp.jpg",
                        "3",
                        "754",
                        "40",
                        "3",
                        "40000",
                        "130m2",
                        "2",
                        "2",
                        "2",
                        "1"});
#line 8
 testRunner.Given("co du lieu chinh", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("cho phep nguoi dung tim du an theo Name, Price, Bedroom, Bathroom, Packing Place," +
            " Area")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FilterSearch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void ChoPhepNguoiDungTimDuAnTheoNamePriceBedroomBathroomPackingPlaceArea()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("cho phep nguoi dung tim du an theo Name, Price, Bedroom, Bathroom, Packing Place," +
                    " Area", new string[] {
                        "mytag"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 22
 testRunner.Given("cho phep nguoi dung nhap lieu \'name\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "Price",
                        "Area",
                        "Bedroom",
                        "Bathroom",
                        "PackingPlace"});
            table2.AddRow(new string[] {
                        "PIS Top Apartment",
                        "10000",
                        "120m2",
                        "3",
                        "3",
                        "1"});
            table2.AddRow(new string[] {
                        "ICON 56 – Modern Style Apartment",
                        "30000",
                        "130m2",
                        "2",
                        "4",
                        "1"});
            table2.AddRow(new string[] {
                        "PIS Serviced Apartment – Boho Style",
                        "70000",
                        "120m2",
                        "3",
                        "2",
                        "1"});
            table2.AddRow(new string[] {
                        "Bigroom with Riverview",
                        "90000",
                        "200m2",
                        "2",
                        "3",
                        "1"});
            table2.AddRow(new string[] {
                        "PIS Serviced Apartment – Style 3",
                        "30000",
                        "130m2",
                        "2",
                        "4",
                        "1"});
            table2.AddRow(new string[] {
                        "Vinhomes Central Park L2 – Duong’s Apartment",
                        "110000",
                        "150m2",
                        "4",
                        "2",
                        "1"});
            table2.AddRow(new string[] {
                        "Saigon Pearl Ruby Block",
                        "30000",
                        "130m2",
                        "3",
                        "3",
                        "1"});
            table2.AddRow(new string[] {
                        "Nguyen Dinh Chinh – Duplex with Balcony",
                        "200000",
                        "120m2",
                        "3",
                        "2",
                        "1"});
            table2.AddRow(new string[] {
                        "Sunshine Ben Thanh",
                        "400000",
                        "130m2",
                        "2",
                        "2",
                        "2"});
#line 23
 testRunner.Then("hien thi danh sach du an vua duoc go", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
