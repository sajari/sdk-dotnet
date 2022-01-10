# Com.Sajari.Sdk.Model.QueryCollectionRequestTrackingType
 - TYPE_UNSPECIFIED: The default / unset value. The API defaults to `NONE` tracking.  - NONE: No tracking.  - CLICK: Click tracking.  A click token is be generated for each result. Results which do not receive clicks fall down the rankings, and similarly low-ranked records which receive clicks are moved up the rankings.  - POS_NEG: Pos/neg tracking.  Pos/neg tokens are generated for each result. Each record in the result set can be marked with pos/neg value for the search. This is then fed back into the ranking algorithm to improve future results. Unlike `CLICK`, if no tokens are reported for records then no action is taken.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

