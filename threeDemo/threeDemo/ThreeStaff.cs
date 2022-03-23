using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeDemo
{
    public class ThreeStaff
    {
        private NodeEmployee root;

        public ThreeStaff ()
        {
            this.root = null;
        }

        public void Add(Employee newEmployee, Employee parentEmployee)
        {
            if (root == null)
            {
                // Create the root element
                this.root = new NodeEmployee(null, newEmployee);
            }
            else
            {
                // find the parent, add newEmployee as a child of the parent
                List<NodeEmployee> children = new List<NodeEmployee> { this.root };
                bool found = false;

                while (found == false)
                {
                    // Inspect the children to find the parent
                    foreach (NodeEmployee nodeItem in children)
                    {
                        if (nodeItem.Employee == parentEmployee)
                        {
                            // found the parent, add newEmployee as a child
                            nodeItem.Children.Add(new NodeEmployee(nodeItem, newEmployee));
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        // go one level deeper
                        // create a list of all children of the children
                        List<NodeEmployee> parents = children;
                        List<NodeEmployee> grandChildren = new List<NodeEmployee>();
                        foreach (NodeEmployee node in parents)
                        {
                            foreach (NodeEmployee childNode in node.Children)
                            {
                                grandChildren.Add(childNode);
                            }
                        }
                        children = grandChildren;
                    }
                }
                // we did not find the parent, so we do not add anything... the method will not end
            }
        }

        public NodeEmployee GetNodeEmployee(string name, Job job)
        {
            if (root == null)
            {
                // element is not found
                return null;
            }
            else
            {
                List<NodeEmployee> children = new List<NodeEmployee> { this.root };
                bool found = false;

                while (found == false)
                {
                    foreach (NodeEmployee nodeItem in children)
                    {
                        if ((nodeItem.Employee.Name == name) && (nodeItem.Employee.JobPosition == job))
                        {
                            // found the element, return it
                            return nodeItem;
                        }
                    }

                    if (!found)
                    {
                        // we did not find the element, go to the next level
                        List<NodeEmployee> parents = children;
                        List<NodeEmployee> grandChildren = new List<NodeEmployee>();

                        // Create a list of all grandchildren
                        foreach (NodeEmployee node in parents)
                        {
                            foreach (NodeEmployee childNode in node.Children)
                            {
                                grandChildren.Add(childNode);
                            }
                        }
                        children = grandChildren;

                        if (children.Count == 0)
                        {
                            // no grandchildren anymore, so element not found
                            return null;
                        }
                    }

                }
                return null;
            }
        }
    }
}