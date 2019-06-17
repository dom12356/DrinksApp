using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksApp.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink { Name = "Mead", Type = "Wine", Description = "Your bones don't break, mine do. That's clear. Your cells react to bacteria and viruses differently than mine. You don't get sick, I do. That's also clear. But for some reason, you and I react the exact same way to water. We swallow it too fast, we choke. We get some in our lungs, we drown. However unreal it may seem, we are connected, you and I. We're on the same curve, just on opposite ends.", Price = 12.50M, Image = "https://www.saga.co.uk/contentlibrary/saga/publishing/verticals/food/drink/jonathan-goodall/guide-to-modern-mead-203649037-768.jpg" },
                    new Drink { Name = "Whiskey", Type = "Spirit", Description = "My money's in that office, right? If she start giving me some bullshit about it ain't there, and we got to go someplace else and get it, I'm gonna shoot you in the head then and there. Then I'm gonna shoot that bitch in the kneecaps, find out where my goddamn money is. She gonna tell me too. Hey, look at me when I'm talking to you, motherfucker. You listen: we go in there, and that nigga Winston or anybody else is in there, you the first motherfucker to get shot. You understand?", Price = 32.50M, Image = "https://d384u2mq2suvbq.cloudfront.net/public/spree/products/1376/jumbo/Whiskey_Fragrance_Oil.jpg?1486557222" },
                    new Drink { Name = "Red Wine", Type = "Wine", Description = "Normally, both your asses would be dead as fucking fried chicken, but you happen to pull this shit while I'm in a transitional period so I don't wanna kill you, I wanna help you. But I can't give you this case, it don't belong to me. Besides, I've already been through too much shit this morning over this case to hand it over to your dumb ass.", Price = 12.50M, Image = "https://images.crateandbarrel.com/is/image/Crate/VineyardRedWinesCHF15" },
                    new Drink { Name = "White Wine", Type = "Wine", Description = "Now that there is the Tec-9, a crappy spray gun from South Miami. This gun is advertised as the most popular gun in American crime. Do you believe that shit? It actually says that in the little book that comes with it: the most popular gun in American crime. Like they're actually proud of that shit. ", Price = 12.50M, Image = "https://target.scene7.com/is/image/Target/GUEST_be7965e7-37b0-435f-b8c4-7c8d762451bf?wid=488&hei=488&fmt=pjpeg" }
                );
            }
            context.SaveChanges();
        }
    }
}
