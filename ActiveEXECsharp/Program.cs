using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections;

namespace CSharpLanguage {
	class CompanyDepartmentTreeNode {
		public int level;
		public List<string> data;

		public CompanyDepartmentTreeNode(int level = 0) {
			this.level = level;
			data = new List<string>();
		}
	}

	class CompanyDepartmentTree {
		public CompanyDepartmentTreeNode root;

		public CompanyDepartmentTree() {
			this.root = new CompanyDepartmentTreeNode(0);
		}
		public int AddNode(string key, string path = "/") {

			return 1;
		}

		public int DeleteNode(string key, string path = "/") {
			return 1;
		}
		public string FindElement(string element) {
			string path = "";
			return path;
		}

		public void PrintList(string path = "/") {

		}
		public void PrintAllElement(string path = "/") {

		}
	}

	class User {
		private CompanyDepartmentTree company;
		private string nowPath;

		public User() {
			this.nowPath = "/";
			this.company = new CompanyDepartmentTree();
		}

		public void AddDepartments(string path = "/") {
		}
		public void InstallPrograms() {

		}
		public void LoadProgramList() {

		}
		public void MoveDepartment() {

		}
		public void AddPrograms() {

		}
	}

	class Program {
		private bool nowLogin = false;

		static void Main(string[] args) {
			User user = new User();
		}
	}
}
