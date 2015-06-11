// ReSharper disable UnusedMember.Local
namespace Specs
{
    using System;

    using Machine.Fakes;
    using Machine.Specifications;

    public class Random_test : WithSubject<Random>
    {
        private static int result;

        private Establish context = () => { };

        private Because of = () => { result = Subject.Next(0, 10); };
        
        private It shouldBeZeroOrMore = () => result.ShouldBeGreaterThanOrEqualTo(0);

        private It shouldBeNineOrLess = () => result.ShouldBeLessThan(10);
    }
}
// ReSharper restore UnusedMember.Local