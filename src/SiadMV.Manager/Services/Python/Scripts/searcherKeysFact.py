import re

def SearchKeysFact(userCase, keysFact):
    keysFactString = "|".join(keysFact)

    counter = {}

    pattern = re.compile(keysFactString)
    m = pattern.findall(userCase)

    for word in m:
        word = word.lower()
        if word in counter:
            counter[word] += 1
        else:
            counter[word] = 1

    print(len(keysFact))                
    print("KeysFact encontrados", counter)
    return counter
