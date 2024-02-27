import http.client

conn = http.client.HTTPSConnection("api.collectapi.com")

headers = {
    'content-type': "application/json",
    'authorization': "apikey 4btYKMw0ceP1igzKb41JZw:6uSIWrHnNF63TsdrJ9uNNz"
    }

conn.request("GET", "/weather/getWeather?data.lang=tr&data.city=ankara", headers=headers)

res = conn.getresponse()
data = res.read()

print(data.decode("utf-8\n").split(":"))

input("")