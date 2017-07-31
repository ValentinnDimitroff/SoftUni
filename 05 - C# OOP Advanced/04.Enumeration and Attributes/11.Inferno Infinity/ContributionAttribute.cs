namespace _11.Inferno_Infinity
{
    using System;

    public class ContributionAttribute : Attribute
    {
        public ContributionAttribute(string author, int revision, string desctiption, params string[] reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Desctiption = desctiption;
            this.Reviewers = reviewers;
        }

        public string Author { get; set; }

        public int Revision { get; set; }

        public string Desctiption { get; set; }

        public string[] Reviewers { get; set; }
    }
}
