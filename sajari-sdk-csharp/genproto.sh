#!/bin/bash -e

function die() {
  echo 1>&2 $*
  exit 1
}

if [ -z "$PROTO_SRC" ]; then
  die "must set PROTO_SRC"
fi

echo 1>&2 "Checking required tools:"
for tool in go protoc protoc-gen-go; do
  q=$(which $tool) || die "didn't find $tool"
  echo 1>&2 "$tool: $q"
done

echo 1>&2 "Building protos:"
for dir in $(find $PROTO_SRC -name '*.proto' | xargs -n1 dirname | sort | uniq); do
  echo 1>&2 "- $dir"
  dest=.${dir#$PROTO_SRC}
  mkdir -p $dest
  echo $dest
  protoc -I$PROTO_SRC --csharp_out $dest --grpc_out $dest $dir/*.proto --plugin=protoc-gen-grpc=/Users/dhowden/Projects/sajari-sdk-csharp/packages/Grpc.Tools.1.0.1/tools/macosx_x64/grpc_csharp_plugin
done