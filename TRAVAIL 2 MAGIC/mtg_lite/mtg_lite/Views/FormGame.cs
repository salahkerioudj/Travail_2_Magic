using mtg_lite.Controllers;
using mtg_lite.Models.Players;

namespace mtg_lite
{
    public partial class FormGame : Form
    {
        private Controller controller;

        public FormGame()
        {
            InitializeComponent();
            controller = new Controller();
            InitZonesDisplay();
            manaPoolDisplay.ManaPool = controller.Player.ManaPool;
        }

        private void InitZonesDisplay()
        {

            libraryDisplay.Zone = controller.Player.Library;
            graveyardDisplay.Zone = controller.Player.Graveyard;
            handDisplay.Hand = controller.Player.Hand;
            battlefieldDisplay.Battlefield = controller.Player.Battlefield;

        }
    }
}