# First Task for System Integration.


Open the solution in the MiniProject directory.\
Run it.\
Send a request to https://localhost:44303//WebService1.asmx containing an xml body like:

```<?xml version="1.0" encoding="utf-8"?>
<soap12:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap12="http://www.w3.org/2003/05/soap-envelope">
  <soap12:Body>
    <HelloWorldAsync xmlns="test">
      <persons>
        <list>
          <PersonDTO>
            <Name>Kim</Name>
            <Email>Kim@mail.US</Email>
            <IP>69.162.81.155</IP>
          </PersonDTO>
          <PersonDTO>
            <Name>Kim</Name>
            <Email>Kim@mail.NO</Email>
            <IP>104.110.0.0</IP>
          </PersonDTO>
        </list>
      </persons>
    </HelloWorldAsync>
  </soap12:Body>
</soap12:Envelope>
```
Our software will determine where in the world a person is from, given their ip-address.\
This information will then be uses, together with the persons name, to calculate their gender and return Ms|Mr|Blank.\
In the example body above, we have used the same name twice, but one has an US ip and the other a NO ip. They will get different titles because of this.
