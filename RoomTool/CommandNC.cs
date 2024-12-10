using HostMgd.ApplicationServices;
using RoomTool.Helpers;
using RoomTool.Views;
using Teigha.Runtime;

namespace RoomTool
{
    public class Commands
    {
        [CommandMethod("RoomTool_MeasureArea")]
        public void MeasureArea()
        {
            var doc = Application.DocumentManager.MdiActiveDocument;
            var db = doc.Database;
            var ed = doc.Editor;
            SpaceHelper.doc = doc;
            SpaceHelper.db = db;
            
            var isShowed = Application.ShowModalWindow(new MainWindow());
        }
    }
}