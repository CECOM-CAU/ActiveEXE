using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections;

namespace CSharpLanguage {

	class CompanyTreeNode {
		public int level;
		public Dictionary<string, CompanyTreeNode> data;

		public CompanyTreeNode(int level = 0) {
			this.level = level;
			data = new Dictionary<string, CompanyTreeNode>();
		}
	}

	class CompanyTree {
		public CompanyTreeNode root;

		public CompanyTree() {
			this.root = new CompanyTreeNode(0);
		}
		public int AddNode(string key, string path = "/") {

			string[] nodePath = path.Split('/');
			CompanyTreeNode nowNode = root;
			Console.WriteLine("{0}", nodePath.Length);
			foreach (string selection in nodePath) {
				if (selection == "")
					break;
				nowNode = nowNode.data[selection];
			}
			CompanyTreeNode department = new CompanyTreeNode(nowNode.level + 1);

			nowNode.data.Add(key, department);

			return 1;
		}
	}
	//  class User {
	//      private string user_id;
	//      private string user_password;


	//      public void getUser() {
	//      }
	//      public void setDepartments() {
	//}

	//  }

	class Program {
		private bool nowLogin = false;

		static void Main(string[] args) {
			CompanyTree company = new CompanyTree();
			company.AddNode("Program");
			company.AddNode("AI", path: "Program/");
			company.AddNode("asdf", path: "Program/AI/");

			Console.WriteLine(company.root.data.ContainsKey("Program"));
			Console.WriteLine(company.root.data["Program"].data.ContainsKey("AI"));
			Console.WriteLine(company.root.data["Program"].data["AI"].data.ContainsKey("asdf"));

		}
	}
}
