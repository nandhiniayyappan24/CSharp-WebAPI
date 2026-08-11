#!/usr/bin/env python3
from pydriller import Repository

repo_path = "../../"
for commit in Repository(repo_path).traverse_commits():
    print(f"{commit.hash[:8]} {commit.author.name} {commit.msg.strip()}")
    break
