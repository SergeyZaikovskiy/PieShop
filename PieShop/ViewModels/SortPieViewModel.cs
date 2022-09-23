using Microsoft.Data.SqlClient;
using PieShop.Domain;

namespace PieShop.ViewModels
{
    public class SortPieViewModel
    {
        public SortPieState NameSort { get; set; }

        public SortPieState PriceSort { get; set; }

        public SortPieState WeightSort { get; set; }

        public SortPieState Current { get; set; }

        public bool Up { get; set; }

        public SortPieViewModel(SortPieState state)
        {           
            NameSort = SortPieState.NameAsc;
            PriceSort = SortPieState.PriceAsc;
            WeightSort = SortPieState.WeightAsc;

            Up = true;
            
            if (state == SortPieState.NameDesc || state == SortPieState.PriceDesc
                || state == SortPieState.WeightDes)
            {
                Up = false;
            }

            switch (state)
            {
                case SortPieState.NameDesc:
                    Current = NameSort = SortPieState.NameAsc;
                    break;
                case SortPieState.PriceAsc:
                    Current = PriceSort = SortPieState.PriceDesc;
                    break;
                case SortPieState.PriceDesc:
                    Current = PriceSort = SortPieState.PriceAsc;
                    break;
                case SortPieState.WeightAsc:
                    Current = WeightSort = SortPieState.WeightDes;
                    break;
                case SortPieState.WeightDes:
                    Current = WeightSort = SortPieState.WeightAsc;
                    break;
                default:
                    Current = NameSort = SortPieState.NameDesc;
                    break;
            }
        }

    }
}
