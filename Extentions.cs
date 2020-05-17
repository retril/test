using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace task1.Models
{
    public static class TasksDbContextExtentions
    {
        public static async Task<Item> GetItem(this ItemsDbContext ctx,Item item)
        {
            return await ctx.Items.FirstOrDefaultAsync(x=>x.Itemid==item.Itemid);
        }

        public static async Task<Item> GetAllItems(this ItemsDbContext ctx, Item item)
        {
            return await ctx.Items.AllAsync(item);
        }
    }
}
