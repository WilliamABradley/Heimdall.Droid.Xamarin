/*
 MIT License

Copyright (c) 2017 NAXAM CO., LTD

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using Java.Lang;

namespace RX.Observables
{
    partial class AsyncOnSubscribe
    {
        public void Call(Java.Lang.Object p1)
        {
            Call((global::RX.Subscriber)p1);
        }
    }

    partial class SyncOnSubscribe
    {
        public void Call(Java.Lang.Object p1)
        {
            Call((global::RX.Subscriber)p1);
        }
    }
}

namespace RX.Internal.Operators
{
    partial class BlockingOperatorToIterator
    {
        partial class SubscriberIterator
        {
            public override void OnNext(Java.Lang.Object p0)
            {
                OnNext((RX.Notification)p0);
            }
        }
    }

    partial class UnicastSubject
    {
        partial class State
        {
            public void Call(Java.Lang.Object p1)
            {
                Call((global::RX.Subscriber)p1);
            }
        }
    }

    partial class CompletableOnSubscribeConcat
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class EmptyObservableHolder
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class NeverObservableHolder
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMergeIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeTimeout
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class OnSubscribeFromArray
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class CompletableOnSubscribeConcatArray
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMergeArray
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMergeDelayErrorArray
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeConcatIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMerge
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMergeDelayErrorIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class OnSubscribeAmb
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeAutoConnect
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeCollect
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFlattenIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFromAsync
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeCombineLatest
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDetach
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFilter
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFromCallable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFromIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeMap
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeGroupJoin
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeOnAssembly
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeOnAssemblyCompletable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeSingle
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeTakeLastOne
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeOnAssemblySingle
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeThrow
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeTimerOnce
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeTimerPeriodically
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribePublishMulticast
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeConcatMap
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeJoin
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeUsing
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeLift
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeRange
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDefer
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDelaySubscription
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDelaySubscriptionOther
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDelaySubscriptionWithSelector
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeRedo
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeReduce
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeReduceSeed
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeRefCount
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDelay
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorAny
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDebounceWithTime
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorCast
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDebounceWithSelector
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDematerialize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorMaterialize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDistinct
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDistinctUntilChanged
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }

        public Java.Lang.Object Call(Java.Lang.Object p0, Java.Lang.Object p1)
        {
            return Call(p0, p1);
        }
    }

    partial class OperatorMerge
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoAfterTerminate
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoOnEach
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoOnRequest
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoOnSubscribe
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoOnUnsubscribe
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorEagerConcatMap
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorBufferWithSingleObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorBufferWithSize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorBufferWithStartEndObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorBufferWithTime
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDelayWithSelector
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorElementAt
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorMapNotification
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorGroupBy
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorAll
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorConcat
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }

        partial class ConcatSubscriber
        {
            public override void OnNext(Java.Lang.Object p0)
            {
                OnNext((Observable)p0);
            }
        }
    }

    partial class SingleOperatorOnErrorResumeNextViaSingle
    {
        public void Call(Java.Lang.Object p0)
        {
            Call((RX.SingleSubscriber)p0);
        }
    }

    partial class OperatorMap
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorFilter
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeLastOne
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorMapPair
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorAsObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorIgnoreElements
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorObsevableOn
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkip
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipLast
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipLastTimed
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorOnBackpressureBuffer
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipTimed
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorUntil
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTimeInterval
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipWhile
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSerialize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSingle
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorObserveOn
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipUntil
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSubscribeOn
    {
        public void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorOnBackpressureDrop
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeLastTimed
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSwitch
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorOnBackpressureLatest
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeTimed
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSwitchIfEmpty
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeUntil
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakUntilPredicate
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTake
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeWhile
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeLast
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorThrottleFirst
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTimestamp
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorToMap
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorToMultimap
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorToObservableList
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorToObservableSortedList
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorUnsubscribeOn
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSampleWithObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSampleWithTime
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithTime
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithSize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorScan
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithStartEndObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithTime
    {
        //public Java.Lang.Object Call(Java.Lang.Object p0)
        //{
        //	return Call((RX.Subscriber)p0);
        //}
    }

    partial class OperatorWindowWithLatestFrom
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithLatestFromMany
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorZip
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorZipIterable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithObservableFactory
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWithLatestFrom
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWithLatestFromMany
    {
        public void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorRetryWithPredicate
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeUntilPredicate
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorOnErrorResumeNextViaFunction
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTimeoutBase
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class SingleOnSubscribeUsing
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class SingleOperatorOnErrorResumeNext
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class SingleDoAfterTerminate
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class SingleOnSubscribeDelaySubscriptionOther
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class SingleOnSubscribeMap
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }
}

namespace RX.Subjects
{
    partial class ReplaySubject
    {
        partial class BoundedState
        {
            public Java.Lang.Object ReplayObserverFromIndex(Java.Lang.Object p0, Java.Lang.Object p1)
            {
                return ReplayObserverFromIndex((Integer)p0, p1);
            }

            public Java.Lang.Object ReplayObserverFromIndexTest(Java.Lang.Object p0, Java.Lang.Object p1, long p2)
            {
                return ReplayObserverFromIndexTest((Integer)p0, p1, p2);
            }
        }

        partial class UnboundedReplayState
        {
            public Java.Lang.Object ReplayObserverFromIndex(Java.Lang.Object p0, Java.Lang.Object p1)
            {
                return ReplayObserverFromIndex((Integer)p0, p1);
            }

            public Java.Lang.Object ReplayObserverFromIndexTest(Java.Lang.Object p0, Java.Lang.Object p1, long p2)
            {
                return ReplayObserverFromIndexTest((Integer)p0, p1, p2);
            }
        }
    }
}

namespace RX.Internal.Util.Unsafe
{
    public partial interface IMessagePassingQueue
    {
    }
}