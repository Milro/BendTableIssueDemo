using SolidEdgeAssembly;
using SolidEdgeDraft;
using SolidEdgeFramework;
using SolidEdgePart;

namespace BendTableIssueDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void CreateDrawing(SolidEdgeFramework.Application seApp, SolidEdgeDocument seDoc)
        {
            if (seDoc is not SheetMetalDocument)
            {
                MessageBox.Show("No Sheet Metal File Open !");
                return;
            };
            SheetMetalDocument seSheetDoc = (SheetMetalDocument)seDoc;
            if (seSheetDoc.BendTable.BendCount < 1)
            {
                MessageBox.Show("No Bends on this sheetmetal file , Please use a sheetmetal file that has bends");
                return;
            }
            DraftDocument draftDocument = seApp.Documents.Add("SolidEdge.DraftDocument");
            ModelLink modelLink = draftDocument.ModelLinks.Add(seDoc.FullName);
            SolidEdgeDraft.DrawingView flatPatternView = null;
            flatPatternView = draftDocument.ActiveSheet.DrawingViews.AddSheetMetalView(modelLink, SolidEdgeDraft.ViewOrientationConstants.igTopView,
                   .125, 0, 0, SolidEdgeDraft.SheetMetalDrawingViewTypeConstants.seSheetMetalFlatView);

         
            //Changing this setting to false manually on the draft template before placing the bend table 
            //through the api will make so the bend direction is correct but , changing it to false in api
            //before placing the bend table has no effect.
            draftDocument.FilePreferences.DVDeriveBendDirectionFromView = false;
            //The bend direction is incorrect on the bend table unless the "Derive Bend Direction From View" setting
            //is set to false in the draft template before running the program. Oddly the bend direction in the bend
            //callout is correct.
            draftDocument.DraftBendTables.Add(flatPatternView, "Normal", 1, 1);



        }

        private void btnCreateDrawing_Click(object sender, EventArgs e)
        {
            OleMessageFilter.Register();
            var seApp = SolidEdgeHelpers.GetSolidEdgeAppReference();
            CreateDrawing(seApp, seApp.ActiveDocument);//No error handling
            OleMessageFilter.Revoke();
        }
    }
}
