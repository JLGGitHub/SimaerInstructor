include "environment.thrift"

namespace cpp instructor
namespace csharp instructor

service InstructorService extends environment.EnvironmentService{
    void ping()
}
