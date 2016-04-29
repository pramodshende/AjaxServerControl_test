using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace AjaxServerControl1
{
    /// <summary>
    /// Summary description for ServerControl1
    /// </summary>
    public class ServerControl1 : ScriptControl
    {
        public ServerControl1()
        {
            //
            // TODO: Add constructor logic here
            //
      ///      Var Query =from CusDetails in db.customer skip (50) Take (10)
    //ObjectDumper.Write(q)
           // var qry = from cusD in DBNull. skip (50) take (10)

        }
        protected override IEnumerable<ScriptDescriptor>
                GetScriptDescriptors()
        {
            ScriptControlDescriptor descriptor = new ScriptControlDescriptor("AjaxServerControl1.ClientControl1", this.ClientID);
            yield return descriptor;
        }

        // Generate the script reference
        protected override IEnumerable<ScriptReference>
                GetScriptReferences()
        {
            yield return new ScriptReference("AjaxServerControl1.ClientControl1.js", this.GetType().Assembly.FullName);
        }
    
    void abc()
        {
        var wordsA = new {"Rahul","ashok","sweta"};
        var wordsB = new {"rahul","ashok","sweta"};
        var mat = wordsA.sequenceequal(wordsB);

        
            Console.WriteLine("The sequences match: {0}", mat);


        }
    }
}