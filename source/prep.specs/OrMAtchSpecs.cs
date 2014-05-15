using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using prep.collections;
using prep.utility.filtering;

namespace prep.specs
{
    public class OrMAtchSpecs 
    {
        public class concern_for_or_match : Observes<OrMatch<Movie>>
        {

        }

        public class when_or_match_is_instantiated : concern_for_or_match
        {
            Establish c = () => {
                left = depends.on<IMatchAn<Movie>>();
                movie = fake.an<Movie>();
            };

            It should_not_have_recive_the_match = () =>
                left.never_received(x => x.matches(movie));

            static IMatchAn<Movie> left;
            static Movie movie;
        }

        public class when_making_an_or_match: concern_for_or_match
        {

            public class and_is_false
            {
                Establish c = () =>
                {
                    depends.on<IMatchAn<Movie>>();
                    depends.on<IMatchAn<Movie>>();
                    movie = fake.an<Movie>();
                };

                Because b = () =>
                    result = sut.matches(movie);

                It should_reurn_false = () =>
                    result.ShouldBeFalse();

                static bool result;
                static Movie movie;
            }
        }
    }
}
