using System;

namespace Assignment_7_Auction
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] Items = new Item[5];
            
            Items[0] = new Item("Exotic Egg", 10000);
            
            Items[1] = new Item("Inn's Gucci belt", 1000000);

            //Console.WriteLine(Items[0].GetItemDescription());
            //Items[0].SetHighestBid(50000,123456);
            //Console.WriteLine(Items[0].GetHighestBid());
            //Console.WriteLine(Items[0].GetBidderID());

            PrintAllItems(Items);

            SetBid(Items, 0, 50000, 123123);

            PrintAllItems(Items);

            EndAuction(Items);

            static void PrintAllItems(Item[] Items)
            {
                for (int i = 0; i < Items.Length; i += 1)
                {
                    if (Items[i] != null)
                    {
                        Console.WriteLine(Items[i].GetInfo());
                    }
                }
            }
            static void SetBid(Item[] Items, int ItemNumber, double bid, int ID)
            {
                if (bid > Items[ItemNumber].GetHighestBid())
                {
                    Items[ItemNumber].SetHighestBid(bid, ID);
                }
            }
            static void EndAuction(Item[] Items)
            {
                for (int i = 0; i < Items.Length; i += 1)
                {
                    if (Items[i] != null)
                    {
                        if (Items[i].GetHighestBid() != Items[i].GetReservePrice())
                        {
                            Console.WriteLine("Item:" + Items[i].GetItemDescription() + "   Sold for:" + Items[i].GetHighestBid()
                                + "   To:" + Items[i].GetBidderID());
                        }
                    }
                }
            }
        }
    }
}
