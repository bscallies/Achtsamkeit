using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

//CategoryManager.cs
namespace Achtsamkeit.Backend
{
    public class CategoryManager
    {
        private const string CategoriesFilePath = "categories.json";

        public List<Category> LoadCategories()
        {
            if (File.Exists(CategoriesFilePath))
            {
                var categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText(CategoriesFilePath));
                return categories;
            }

            return new List<Category>();
        }

        public void SaveCategories(List<Category> categories)
        {
            File.WriteAllText(CategoriesFilePath, JsonConvert.SerializeObject(categories));
        }

        public void AddSubcategory(Category category, string subcategory)
        {
            category.Subcategories.Add(subcategory);
        }
        public void GetCategoryAndSubcategory(TreeNode selectedNode, string newSubcategory, out string category, out string subcategory)
        {
            if (selectedNode.Parent == null)  // It's a Category
            {
                category = selectedNode.Text;
                subcategory = newSubcategory;
                // UI update should be done in UI code (like Form1.cs), not here.
            }
            else  // It's a Subcategory
            {
                category = selectedNode.Parent.Text;
                subcategory = selectedNode.Text;
            }
        }

        public List<Category> GetCategoriesFromTreeView(TreeNodeCollection nodes)
        {
            return nodes.Cast<TreeNode>()
                        .Select(n => new Category
                        {
                            Name = n.Text,
                            Subcategories = n.Nodes.Cast<TreeNode>().Select(s => s.Text).ToList()
                        }).ToList();
        }
    }

}
