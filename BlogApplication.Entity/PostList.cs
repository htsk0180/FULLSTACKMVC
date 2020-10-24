//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogApplication.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostList()
        {
            this.PostCommentList = new HashSet<PostCommentList>();
            this.PostTagList = new HashSet<PostTagList>();
        }
    
        public int Id { get; set; }
        public string PostHeader { get; set; }
        public System.DateTime PostDate { get; set; }
        public string PostBody { get; set; }
        public string PostLink { get; set; }
        public int CategoryId { get; set; }
    
        public virtual CategoryList CategoryList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostCommentList> PostCommentList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostTagList> PostTagList { get; set; }
    }
}
