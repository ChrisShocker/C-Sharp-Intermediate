using System;

namespace StackOverflow_Post_Exercise
{
    internal partial class Program
    {
        public class Post
        {
            private int upVoteCount = 0;
            private int downVoteCount = 0;
            private DateTime _creationTime = DateTime.Now;

            public string _title { get; private set; }
            public string _description { get; set; }

            public Post(string title, string descrip)
            {
                this._title = title;
                this._description = descrip;
            }

            public void getUpvoteCount()
            {
                Console.WriteLine("Current Up Votes: {0}", upVoteCount);
                return;
            }
            public void getDownVoteCount()
            {
                Console.WriteLine("Current Down Votes: {0}", downVoteCount);
                return;
            }
            public void getCreationTime()
            {
                Console.WriteLine("Post Created at: {0}", _creationTime);
                return;
            }

            public void printPost()
            {
                Console.WriteLine(_title);
                Console.WriteLine(_description);
                Console.WriteLine("Post Created at: {0}", _creationTime);
                Console.WriteLine("Current Up Votes: {0}", upVoteCount);
                Console.WriteLine("Current Down Votes: {0}", downVoteCount);
            }

            public int upVote() {
                return upVoteCount +=1;
            }

            public int downVote() {
                return downVoteCount +=1;
            }
        }
    }
}
