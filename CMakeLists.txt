cmake_minimum_required(VERSION 3.30)
project(easy_algorithms C)

set(CMAKE_C_STANDARD 11)

add_executable(easy_algorithms
        linked-list/linked_list.c
        binary-search/binary_search.c
        array/array.c)
