﻿namespace Octopus.Client.Model
{
    public enum FeedType
    {
        None = 0,
        NuGet,
        Docker,
        Maven,
        OctopusProject,
        GitHub,
        BuiltIn,
        Helm,
        AwsElasticContainerRegistry,
        S3
    }
}