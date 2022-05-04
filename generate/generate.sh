#!/usr/bin/env bash

set -eo pipefail

cd "$(dirname "$0")"

function die() {
    echo 1>&2 $*
    exit 1
}

if [ -z "$GEN_PATH" ]; then
    die "GEN_PATH must be set, e.g. /path/to/sajari/sdk-dotnet"
fi

VERSION=5.1.0

docker-entrypoint.sh generate \
    -i /openapi.json \
    -g csharp-netcore \
    -o $GEN_PATH \
    --artifact-version $VERSION \
    --http-user-agent "sajari-sdk-csharp-$VERSION" \
    --group-id Com.Sajari \
    --git-host "github.com/sajari" \
    --git-repo-id sdk-dotnet \
    --additional-properties packageName=Com.Sajari.Sdk \
    --additional-properties packageVersion=$VERSION
