using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoresEmpresarial
{

    // <T> - esse TEZÃO representa GENERIC
    // Permite definir o tipo específico
    // para TreeNode quando ele for declarado/instanciado
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; } 
        
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while(current.Parent != null)
            {
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
}