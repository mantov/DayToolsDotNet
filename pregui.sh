#!/bin/sh
git add .
git commit -m "$1"
git push
git fetch --all --prune
git rebase
