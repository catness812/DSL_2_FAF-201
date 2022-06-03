using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSystem
{
    public class DslVisitor : DslBaseVisitor<object?>
    {
        private Dictionary<int, (string axiom, int applies, int angle, int length, StringBuilder rule, Color color)> freestyles = new();
        public override object? VisitFreestyle(DslParser.FreestyleContext context)
        {
            (string axiom, int applies, int angle, int length, StringBuilder rule, Color color) freestyle;
            // axiom -> starting point
            freestyle.axiom = context.axiom().GetText();

            // applies -> number of applications of the given rules on the string
            freestyle.applies = int.Parse(context.applies().GetText());

            // angle
            var angle = int.Parse(context.angle().GetText());
            // handle values of angle
            if (angle >= 0 && angle <= 360)
            {
                freestyle.angle = angle;
            }
            else
            {
                throw new Exception("The angle values must be between 0 and 360 inclusive.");
            }

            // length -> lenght of each unit to be drawn
            freestyle.length = int.Parse(context.length().GetText());

            // rules
            var rules = context.rules().GetText();
            freestyle.rule = Parse(freestyle.axiom, freestyle.applies, rules);

            // color
            var color = context.color();
            if (color != null)
            {
                freestyle.color = Color.FromName(color.GetText());
            }
            else
            {
                freestyle.color = Color.Blue;
            }

            // add the current valid instance of freestyle function (its values) to dictionary
            freestyles.Add(freestyles.Count(), freestyle);

            return new ValueTuple<int, int, int, StringBuilder, Color>(freestyle.applies, freestyle.angle, freestyle.length, freestyle.rule, freestyle.color);
            ;
        }

        private StringBuilder Parse(string axiom, int applies, string rule)
        {
            Dictionary<string, string> transitions = new();
            rule = rule
                .Replace("{", string.Empty)
                .Replace("}", string.Empty);

            string[] rules = rule.Split(',');

            foreach (var item in rules)
            {
                string[] value = item.Split(':');

                transitions.Add(value[0][1..^1], value[1][1..^1]);
            }

            // verify if the axiom is contained in the dictionary
            if (!transitions.ContainsKey(axiom))
            {
                throw new Exception("The starting point (axiom) was not found.");
            }

            StringBuilder sb = new StringBuilder(axiom);

            return ReplaceRecursively(sb, applies);

            StringBuilder ReplaceRecursively(StringBuilder path, int counter)
            {
                // base case -> exit recursion
                if (counter == 0)
                {
                    return path;
                }

                // perform changes on string builder
                for (int i = 0; i < path.Length; i++)
                {
                    var replacement = "";
                    // take each state from the given string
                    var state = path[i].ToString();
                    // verify whether transitions map contains as key current state
                    if (transitions.ContainsKey(state))
                    {
                        // extract value of the given key from map
                        replacement = transitions[path[i].ToString()];
                    }
                    // go over the "symbols" that are not present in map
                    else
                    {
                        continue;
                    }
                    // replace current state with its production (transition extracted from dictionary)
                    path = path.Remove(i, 1).Insert(i, replacement);
                    // jump over states newly added and go to the next state of the initial string builder
                    i += replacement.Length - 1;
                }

                // replace recursively symbols from given string based on already changed sb and value of "applies"
                return ReplaceRecursively(path, --counter);
            }
        }

        public override object VisitLstree(DslParser.LstreeContext context)
        {
            Console.WriteLine(context.GetText());
            return base.VisitLstree(context);
        }
    }
}
