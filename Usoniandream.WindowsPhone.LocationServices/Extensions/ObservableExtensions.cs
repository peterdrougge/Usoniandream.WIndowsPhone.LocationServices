using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using RestSharp;
using System.Reactive.Linq;

namespace Usoniandream.WindowsPhone.LocationServices.Extensions
{
    public static class ObservableExtensions
    {
        public static IObservable<TResult> FromCallbackPattern<T, TResult>(T param, Action<T, Action<TResult>> asyncCall)
        {
            return Observable
                .Create<TResult>(observer =>
                {
                    var subscribed = true;
                    asyncCall(param, value =>
                    {
                        if (!subscribed) return;
                        observer.OnNext(value);
                        observer.OnCompleted();
                    });
                    return () =>
                    {
                        subscribed = false;
                    };
                });
        }

        public static IObservable<string> ExecuteAsync(this IRestClient client, IRestRequest request)
        {
            Action<IRestRequest, Action<IRestResponse>> callback = (r, a) => client.ExecuteAsync(r, a);
            return FromCallbackPattern(request, callback).Select(x => x.Content);
        }

        public static IObservable<T> ExecuteAsync<T>(this IRestClient client, IRestRequest request) where T : new()
        {
            Action<IRestRequest, Action<IRestResponse<T>>> callback = (r, a) => client.ExecuteAsync(r, a);
            return FromCallbackPattern(request, callback).Select(x => x.Data);
        }

    }
}
