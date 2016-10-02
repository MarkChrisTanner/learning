#! /usr/bin/env python3

import random
import os


def dice_roll(sides):
    you_got = random.randint(1, sides)
    return you_got


def set_roll(dice_count, dice_sides, number_to_beat):
    d_set = []
    counter = 0
    while dice_count >= 1:
        d_set.append(dice_roll(dice_sides))
        dice_count -= 1
    print(str(crit_count(dice_sides, d_set)) + ' Are critical hits')
    above_mark(number_to_beat, d_set)
    return d_set


def crit_count(dice_sides, dice_set):
    counter = 0
    for roll in dice_set:       # Critical strike
        if roll == dice_sides:
            counter += 1
        if roll == 1:           # Critical fail
            counter -= 1
    # The idea is that hitting 0 is alright, having positive is good, hitting negative is bad.
    return counter


def above_mark(number_to_beat, dice_set):
    counter = 0
    for dice in dice_set:
        if dice >= number_to_beat:
            counter += 1
    print('%s Dice beat %s benchmark' % (int(counter), int(number_to_beat)))


def get_from_user():
    number_of_dice = int(input('\nHow many dice need to be rolled? > '))
    dice_sides = int(input('\nHow many sides do the dice have? > '))
    break_number = int(input('\nWhat is the number you have to beat? > '))
    print()
    print(set_roll(number_of_dice, dice_sides, break_number))


get_from_user()
# print(set_roll(10, 10, 6))
