#!/usr/bin/env python3
from pydriller import Repository
for commit in Repository('../../').traverse_commits():
    print(commit.hash[:8], commit.msg.strip())
    break
