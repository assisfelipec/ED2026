using ArvoreEmpresarial;
using ArvoresEmpresarial;

Tree<person> Company = new Tree<person>();

TreeNode<person> Root = new TreeNode<person> ();
Root.Data = new person("Marcin Jamro", "CEO");
Company.Root = Root;

Company.Root.Children = new List<TreeNode<person>>
{
    new TreeNode<person> { Data = new person("John Smith", "Head of Development"), Parent = Company.Root }
};