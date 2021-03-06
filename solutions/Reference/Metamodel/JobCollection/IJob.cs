//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2021.LabWorkflows.JobCollection
{
    
    
    /// <summary>
    /// The public interface for Job
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Job))]
    [XmlDefaultImplementationTypeAttribute(typeof(Job))]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/ttc21/jobCollection#//Job")]
    public partial interface IJob : IModelElement
    {
        
        /// <summary>
        /// The state property
        /// </summary>
        [DisplayNameAttribute("state")]
        [CategoryAttribute("Job")]
        [XmlElementNameAttribute("state")]
        [XmlAttributeAttribute(true)]
        JobStatus State
        {
            get;
            set;
        }
        
        /// <summary>
        /// The protocolStepName property
        /// </summary>
        [DisplayNameAttribute("protocolStepName")]
        [CategoryAttribute("Job")]
        [XmlElementNameAttribute("protocolStepName")]
        [XmlAttributeAttribute(true)]
        string ProtocolStepName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The previous property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("previous")]
        [CategoryAttribute("Job")]
        [XmlElementNameAttribute("previous")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("next")]
        [ConstantAttribute()]
        IOrderedSetExpression<IJob> Previous
        {
            get;
        }
        
        /// <summary>
        /// The next property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("next")]
        [CategoryAttribute("Job")]
        [XmlElementNameAttribute("next")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("previous")]
        [ConstantAttribute()]
        IOrderedSetExpression<IJob> Next
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the State property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StateChanging;
        
        /// <summary>
        /// Gets fired when the State property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StateChanged;
        
        /// <summary>
        /// Gets fired before the ProtocolStepName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProtocolStepNameChanging;
        
        /// <summary>
        /// Gets fired when the ProtocolStepName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProtocolStepNameChanged;
    }
}

