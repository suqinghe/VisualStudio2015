namespace CheckInventoryWorkflowLib {
    
    #line 23 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 24 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 25 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 26 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 27 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 28 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using AutoLotDisconnectedLayer;
    
    #line default
    #line hidden
    
    #line 29 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Data.Common;
    
    #line default
    #line hidden
    
    #line 1 "G:\visual studio 2015\Projects\WFDemo\CheckInventoryWorkflowLib\CheckInventory.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class CheckInventory : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = CheckInventory_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext0 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext1 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext2 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new CheckInventory_TypedDataContext2(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2 refDataContext3 = ((CheckInventory_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<System.Data.DataTable>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext4 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext5 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext6 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new CheckInventory_TypedDataContext2(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2 refDataContext7 = ((CheckInventory_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext8 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new CheckInventory_TypedDataContext2(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2 refDataContext9 = ((CheckInventory_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext10 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new CheckInventory_TypedDataContext2(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2 refDataContext11 = ((CheckInventory_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<string>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext12 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new CheckInventory_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext13 = ((CheckInventory_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = CheckInventory_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new CheckInventory_TypedDataContext2(locations, activityContext, true);
                }
                CheckInventory_TypedDataContext2 refDataContext14 = ((CheckInventory_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext0 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext1 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext2 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                CheckInventory_TypedDataContext2 refDataContext3 = new CheckInventory_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<System.Data.DataTable>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext4 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext5 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext6 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                CheckInventory_TypedDataContext2 refDataContext7 = new CheckInventory_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext8 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                CheckInventory_TypedDataContext2 refDataContext9 = new CheckInventory_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext10 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                CheckInventory_TypedDataContext2 refDataContext11 = new CheckInventory_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<string>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext12 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                CheckInventory_TypedDataContext2_ForReadOnly valDataContext13 = new CheckInventory_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                CheckInventory_TypedDataContext2 refDataContext14 = new CheckInventory_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new InventoryDALDisLayer(@\"Data Source=SZC71-PC\\SQLEXPRESS;Initial Catalog=AutoLo" +
                            "t;User Id=sa;Password=ab998CD112;\")") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "AutoLotInventory.GetAllInventory()") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Inventory") 
                        && (CheckInventory_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(from car in Inventory.AsEnumerable()\n where (string)car[\"Color\"] == RequestedCol" +
                            "or &&\n (string)car[\"Make\"] == RequestedMake select car).Any()") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedMake") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"Yes sir! We can send you {0} {1} as soon as {2}!\",\nRequestedColor," +
                            " RequestedMake, DateTime.Now)") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FormattedResponse") 
                        && (CheckInventory_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"Please, we will pay you to get this {0} off our lot!\",\nRequestedMa" +
                            "ke)") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FormattedResponse") 
                        && (CheckInventory_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "String.Format(\"Yes, we have a {0} {1} you can purchase\",RequestedColor,RequestedM" +
                            "ake)") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FormattedResponse") 
                        && (CheckInventory_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedColor") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedMake") 
                        && (CheckInventory_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "FormattedResponse") 
                        && (CheckInventory_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new CheckInventory_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new CheckInventory_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new CheckInventory_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new CheckInventory_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new CheckInventory_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new CheckInventory_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CheckInventory_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CheckInventory_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CheckInventory_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CheckInventory_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CheckInventory_TypedDataContext1 : CheckInventory_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CheckInventory_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RequestedColor {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string FormattedResponse {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string RequestedMake {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "RequestedColor") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "FormattedResponse") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "RequestedMake") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return CheckInventory_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CheckInventory_TypedDataContext1_ForReadOnly : CheckInventory_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CheckInventory_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RequestedColor {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string FormattedResponse {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string RequestedMake {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "RequestedColor") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "FormattedResponse") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "RequestedMake") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return CheckInventory_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CheckInventory_TypedDataContext2 : CheckInventory_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CheckInventory_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected AutoLotDisconnectedLayer.InventoryDALDisLayer AutoLotInventory {
                get {
                    return ((AutoLotDisconnectedLayer.InventoryDALDisLayer)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable Inventory {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 67 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
          Inventory;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr3Get() {
                
                #line 67 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
          Inventory;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(System.Data.DataTable value) {
                
                #line 67 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                
          Inventory = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 108 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                FormattedResponse;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 108 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                FormattedResponse;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(string value) {
                
                #line 108 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                
                FormattedResponse = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 121 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                FormattedResponse;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 121 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                FormattedResponse;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(string value) {
                
                #line 121 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                
                FormattedResponse = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 90 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  FormattedResponse;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr11Get() {
                
                #line 90 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                  FormattedResponse;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(string value) {
                
                #line 90 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                
                  FormattedResponse = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 151 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                FormattedResponse;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 151 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                FormattedResponse;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(string value) {
                
                #line 151 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                
                FormattedResponse = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 3)].Name != "AutoLotInventory") 
                            || (locationReferences[(offset + 3)].Type != typeof(AutoLotDisconnectedLayer.InventoryDALDisLayer)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Inventory") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                return CheckInventory_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class CheckInventory_TypedDataContext2_ForReadOnly : CheckInventory_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public CheckInventory_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public CheckInventory_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected AutoLotDisconnectedLayer.InventoryDALDisLayer AutoLotInventory {
                get {
                    return ((AutoLotDisconnectedLayer.InventoryDALDisLayer)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable Inventory {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 55 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<AutoLotDisconnectedLayer.InventoryDALDisLayer>> expression = () => 
          new InventoryDALDisLayer(@"Data Source=SZC71-PC\SQLEXPRESS;Initial Catalog=AutoLot;User Id=sa;Password=ab998CD112;");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public AutoLotDisconnectedLayer.InventoryDALDisLayer @__Expr0Get() {
                
                #line 55 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
          new InventoryDALDisLayer(@"Data Source=SZC71-PC\SQLEXPRESS;Initial Catalog=AutoLot;User Id=sa;Password=ab998CD112;");
                
                #line default
                #line hidden
            }
            
            public AutoLotDisconnectedLayer.InventoryDALDisLayer ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 60 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
          null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr1Get() {
                
                #line 60 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
          null;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 72 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
          AutoLotInventory.GetAllInventory();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr2Get() {
                
                #line 72 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
          AutoLotInventory.GetAllInventory();
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 79 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          (from car in Inventory.AsEnumerable()
 where (string)car["Color"] == RequestedColor &&
 (string)car["Make"] == RequestedMake select car).Any();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 79 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
          (from car in Inventory.AsEnumerable()
 where (string)car["Color"] == RequestedColor &&
 (string)car["Make"] == RequestedMake select car).Any();
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 102 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              RequestedMake;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 102 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
              RequestedMake;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 113 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                String.Format("Yes sir! We can send you {0} {1} as soon as {2}!",
RequestedColor, RequestedMake, DateTime.Now);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 113 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                String.Format("Yes sir! We can send you {0} {1} as soon as {2}!",
RequestedColor, RequestedMake, DateTime.Now);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 126 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                String.Format("Please, we will pay you to get this {0} off our lot!",
RequestedMake);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 126 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                String.Format("Please, we will pay you to get this {0} off our lot!",
RequestedMake);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 95 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  String.Format("Yes, we have a {0} {1} you can purchase",RequestedColor,RequestedMake);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 95 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                  String.Format("Yes, we have a {0} {1} you can purchase",RequestedColor,RequestedMake);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 138 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                RequestedColor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 138 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                RequestedColor;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 143 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                RequestedMake;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 143 "G:\VISUAL STUDIO 2015\PROJECTS\WFDEMO\CHECKINVENTORYWORKFLOWLIB\CHECKINVENTORY.XAML"
                return 
                RequestedMake;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 3)].Name != "AutoLotInventory") 
                            || (locationReferences[(offset + 3)].Type != typeof(AutoLotDisconnectedLayer.InventoryDALDisLayer)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Inventory") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                return CheckInventory_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
