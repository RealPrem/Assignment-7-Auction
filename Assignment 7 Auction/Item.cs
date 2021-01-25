using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7_Auction
{
    class Item
    {
        private string ItemDescription;
        private double ReservePrice;
        private double HighestBid;
        private int BidderID;

        public Item(string ItemDescription, double ReservePrice)
        {
            this.ItemDescription = ItemDescription;
            this.ReservePrice = ReservePrice;
            HighestBid = ReservePrice;
        }
        public string GetItemDescription()
        {
            return ItemDescription;
        }
        public double GetReservePrice()
        {
            return ReservePrice;
        }
        public bool SetHighestBid(double Bid, int ID)
        {
            if (Bid > HighestBid)
            {
                HighestBid = Bid;
                SetBidderID(ID);
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, Bid not high enough");
                return false;
            }
        }
        public double GetHighestBid()
        {
            return HighestBid;
        }
        public void SetBidderID(int ID)
        {
            BidderID = ID;
        }
        public int GetBidderID()
        {
            return BidderID;
        }
        public string GetInfo()
        {
            return ItemDescription + " " + HighestBid + " " + ReservePrice;
        }
    }

}
